using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace ITunesTask.Search
{
    public class CacheMemory
    {
        static CacheMemory()
        {
            Cache = new MemoryCache(new MemoryCacheOptions());
        }

        protected static IMemoryCache Cache { get; private set; }

        protected static void CacheData(string key, object data)
        {
            if (data != null)
            {
                Cache.Set(key, data, DateTime.Now.AddHours(1));
            }
        }
    }
}
