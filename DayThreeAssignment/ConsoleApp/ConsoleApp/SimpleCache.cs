using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    public class SimpleCache
    {
        private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

        public void Add(string key, object value)
        {
            Cache.Add(key, value);
        }

        public object this[string key]
        {
            get
            {
                if (Cache.ContainsKey(key))
                {
                    return Cache[key];
                }
                throw new KeyNotFoundException("Invalid or key not found");
            }
        }

        public bool Clear(string key)
        {
            return Cache.Remove(key);
        }

        public void Update(string key, object value)
        {
            if (Cache.ContainsKey(key))
            {
                Cache[key] = value;
            }
            else
            {
                Cache.Add(key, value);
            }
        }

        public object Retrive(string key)
        {
            object value;
            if (Cache.TryGetValue(key, out value) == false)
            {
                return string.Format("Invalid or key not found: {0}", key); 
            }
            return value;
        }

        public T Retrive<T>(string key)
        {
            return (T) Retrive(key);
        }
    }
}
