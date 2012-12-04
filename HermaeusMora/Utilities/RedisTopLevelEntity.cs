using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svekla.Utilities
{
    public class RedisTopLevelEntity
    {
        public enum EntityType
        {
            String,
            Hash,
            List,
            Set,
            SortedSet
        }

        public String Key
        { get; set; }

        public EntityType Type
        { get; set; }

        public DateTime ExpiresAt
        { get; set; }

        public static EntityType ParseType(String type)
        {
            type = type.ToLower();

            if (type == "string")
                return EntityType.String;
            else if (type == "sortedset")
                return EntityType.SortedSet;
            else if (type == "set")
                return EntityType.Set;
            else if (type == "list")
                return EntityType.List;
            else if (type == "hash")
                return EntityType.Hash;
            else
                throw new Exception();
        }
    }
}
