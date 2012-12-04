using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightIdeasSoftware;

namespace Svekla.Utilities
{
    class RedisKeysDataSource : IVirtualListDataSource
    {
        List<RedisTopLevelEntity> keys = new List<RedisTopLevelEntity>();

        public RedisKeysDataSource(List<RedisTopLevelEntity> source)
        { keys = source; }

        public object GetNthObject(int n)
        {
            return keys[n];
        }

        public int GetObjectCount()
        {
            return keys.Count;
        }

        public int GetObjectIndex(object model)
        {
            RedisTopLevelEntity entity = model as RedisTopLevelEntity;
            if (entity == null) throw new Exception();
            return keys.IndexOf(entity);
        }

        public void PrepareCache(int first, int last)
        {
        }

        public int SearchText(string value, int first, int last, OLVColumn column)
        {
            return 0; // TODO
        }

        public void Sort(OLVColumn column, System.Windows.Forms.SortOrder order)
        {
            // TODO
        }

        public void AddObjects(System.Collections.ICollection modelObjects)
        {
            foreach (Object o in modelObjects)
                keys.Add((RedisTopLevelEntity)o);
        }

        public void RemoveObjects(System.Collections.ICollection modelObjects)
        {
            foreach (Object o in modelObjects)
                keys.Remove((RedisTopLevelEntity)o);
        }

        public void SetObjects(System.Collections.IEnumerable collection)
        {
        }
    }
}
