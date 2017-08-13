using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    public class SimpleCache
    {
        private static readonly Dictionary<string, CacheItem> Cache = new Dictionary<string, CacheItem>();

        public void Add(string key, object value)
        {
            Cache.Add(key, new CacheItem() { Value = value, Created = DateTime.Now.Ticks });
        }

        public object this[string key]
        {
            get
            {
                if (Cache.ContainsKey(key))
                {
                    if ((Cache[key].Created + 30000) > DateTime.Now.Ticks)
                    {
                        return Cache[key].Value;
                    }
                    Cache.Remove(key);
                }
                return null;
            }
        }

        public bool Clear(string key)
        {
            return Cache.Remove(key);
        }

        public void Update(string key, object value)
        {
            CacheItem cacheItem = new CacheItem();
            cacheItem.Value = value;
            Cache[key] = cacheItem;
        }

        public class CacheItem
        {
            public object Value { get; set; }
            public long Created { get; set; }
        }

        public object Retrive(string key)
        {
            CacheItem cacheItem;
            if (Cache.TryGetValue(key, out cacheItem) == false)
            {
                return string.Format("Invalid or key not found: {0}", key); 
            }
            return cacheItem.Value;
        }
    }
}
