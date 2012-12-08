using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Redis;

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

        public static EntityType ParseType(RedisKeyType type)
        {

            if (type == RedisKeyType.String)
                return EntityType.String;
            else if (type == RedisKeyType.SortedSet)
                return EntityType.SortedSet;
            else if (type == RedisKeyType.Set)
                return EntityType.Set;
            else if (type == RedisKeyType.List)
                return EntityType.List;
            else if (type == RedisKeyType.Hash)
                return EntityType.Hash;
            else
                throw new Exception();
        }
    }
}
