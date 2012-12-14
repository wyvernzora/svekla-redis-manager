using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svekla.Utilities
{
    /// <summary>
    /// Class housing all kinds of extension methods.
    /// </summary>
    public static class Extensions
    {
        #region Dictionary

        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue def)
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key];
            else
                return def;
        }

        public static TValue GetOrDefault<Tkey, TValue>(this Dictionary<Tkey, TValue> dictionary, Tkey key)
        { return dictionary.GetOrDefault(key, default(TValue)); }

        #endregion
    }
}
