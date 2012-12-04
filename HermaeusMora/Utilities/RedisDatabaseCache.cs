using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Svekla.Utilities
{
    public class RedisDatabaseCache
    {
        public class CachedEntry : IEquatable<CachedEntry>
        {
            public Byte[] KeyHash { get; set; }
            public RedisTopLevelEntity.EntityType Type { get; set; }
            public DateTime TTL { get; set; }
            public Int32 SlotIndex { get; set; }
            public Boolean Delete { get; set; }

            public bool Equals(CachedEntry other)
            {
                if (!GetByteString(KeyHash).Equals(GetByteString(other.KeyHash)))
                    return false;
                if (Type != other.Type)
                    return false;
                if (TTL != other.TTL)
                    return false;
                return true;
            }
        }

        // top level entitiy cache { md5, entity }
        private Dictionary<String, CachedEntry> cachedEntities = new Dictionary<string, CachedEntry>(); // main cache
        private Dictionary<String, CachedEntry> cachedEntitiesDelts = new Dictionary<string, CachedEntry>(); // cache changes
        private Queue<Int32> emptyCacheSlots = new Queue<Int32>(); // empty cache entry slots
        private Int32 emptyAppendSlot = 0;

        public RedisDatabaseCache()
        {

        }

        #region Top Level Cache

        public Boolean IsCached(String key)
        {
            return cachedEntities.ContainsKey(GetByteString(GetMd5(key)));
        }

        public CachedEntry GetCachedInfo(String key)
        {
            String intKey = GetByteString(GetMd5(key));
            if (cachedEntities.ContainsKey(intKey))
                return cachedEntities[intKey];
            else
                return null;
        }

        public void UpdateCache(RedisTopLevelEntity entity)
        {
            String intKey = GetByteString(GetMd5(entity.Key));
            CachedEntry entry = new CachedEntry()
            { KeyHash = GetMd5(entity.Key), Type = entity.Type, TTL = entity.ExpiresAt };
            if (cachedEntities.ContainsKey(intKey))
            {
                if (!cachedEntities[intKey].Equals(entry))
                { // update entry if different
                    entry.SlotIndex = cachedEntities[intKey].SlotIndex; // inherit slot index
                    cachedEntities[intKey] = entry; // modify in cache
                    cachedEntitiesDelts[intKey] = entry; // flag as modified
                }
            }
            else
            {   // entry does not exist, add it
                entry.SlotIndex = GetNextEmptySlot();
                cachedEntities[intKey] = entry;
                cachedEntitiesDelts[intKey] = entry;
            }

        }

        public void RemoveFromCache(String key)
        {
            String intKey = GetByteString(GetMd5(key));
            if (!cachedEntities.ContainsKey(intKey)) return;

            CachedEntry entry = cachedEntities[intKey];

            // remove it from cached entries
            cachedEntities.Remove(intKey);

            // return its slot index to free slot queue
            emptyCacheSlots.Enqueue(entry.SlotIndex);

            // flag it as modified
            entry.Delete = true;
            cachedEntitiesDelts[intKey] = entry;
        }

        private Int32 GetNextEmptySlot()
        {
            if (emptyCacheSlots.Count > 0)
                return emptyCacheSlots.Dequeue();
            else
                return emptyAppendSlot++;
        }

        #endregion

        #region Save/Load

        /* Metadata:
         * 
         * 0000   "P.MORA.C"
         * 0008   saveTime
         * ---------------------------> 16 bytes header
         * 
         * Entry format:
         * 
         * 0001   1 Byte      Flag { 0xD5 - Entry; 0xD6 - Empty }
         * 0002   16 Bytes    Key
         * 0018   8 Bytes     TTL
         * 0019   1 Byte      Type
         * ---------------------------> 26 bytes/entry
         */

        public void LoadFile(String filename)
        {
            if (!File.Exists(filename))
                return;

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                // read header
                Byte[] hdr = new Byte[8];
                fs.Read(hdr, 0, 8);
                String sHdr = new string(Encoding.ASCII.GetChars(hdr));
                if (sHdr != "P.MORA.C") return;

                // read save time
                Byte[] st = new Byte[8];
                fs.Read(st, 0, 8);
                DateTime sT = new DateTime(BitConverter.ToInt64(st, 0));

                // read entries
                Int32 entC = ((int)fs.Length - 16) / 26;
                for (int i = 0; i < entC; i++)
                {
                    fs.Position = 16 + i * 26;
                    Byte flag = (byte)fs.ReadByte();

                    if (flag != 0xD5)
                    {
                        emptyCacheSlots.Enqueue(i);
                        continue;
                    }

                    CachedEntry ce = new CachedEntry();
                    ce.Delete = false;
                    ce.SlotIndex = i;
                    Byte[] bhash = new byte[16];
                    Byte[] bttl = new byte[8];

                    fs.Read(bhash, 0, 16);
                    fs.Read(bttl, 0, 8);

                    ce.KeyHash = bhash;
                    ce.TTL = new DateTime(BitConverter.ToInt64(bttl, 0));
                    ce.Type = (RedisTopLevelEntity.EntityType)fs.ReadByte();

                    cachedEntities.Add(GetByteString(ce.KeyHash), ce);
                }

            }
        }

        public void WriteFile(String filename)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filename)))
                Directory.CreateDirectory(Path.GetDirectoryName(filename));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                // write header
                fs.Position = 0;
                fs.Write(Encoding.ASCII.GetBytes("P.MORA.C"), 0, 8);

                // append file untils it is long enough to fit all slots
                Int32 flen = 16 + 26 * emptyAppendSlot;
                while (fs.Length < flen) fs.WriteByte(0);

                // write all delta values
                foreach (CachedEntry ce in cachedEntitiesDelts.Values)
                {
                    fs.Position = 16 + 26 * ce.SlotIndex;
                    if (!ce.Delete)
                    {
                        fs.WriteByte(0xD5);
                        fs.Write(ce.KeyHash, 0, 16);
                        fs.Write(BitConverter.GetBytes(ce.TTL.Ticks), 0, 8);
                        fs.WriteByte((byte)ce.Type);
                    }
                    else
                    {
                        fs.WriteByte(0xD6);
                    }
                }

                // write save time
                fs.Position = 8;
                fs.Write(BitConverter.GetBytes(DateTime.Now.Ticks), 0, 8);

                // save file
                fs.Flush();

                // drop all deltas
                cachedEntitiesDelts.Clear();
            }
        }

        #endregion

        #region Utilities

        public static Byte[] GetMd5(String value)
        {
            MD5 hasher = MD5.Create();
            return hasher.ComputeHash(Encoding.UTF8.GetBytes(value));
        }

        public static string GetByteString(Byte[] value)
        {
            return Convert.ToBase64String(value);
        }

        #endregion
    }
}
