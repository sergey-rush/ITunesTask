using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace ITunesTask.Search
{
    public static class Extensions
    {
        public static T Deserialize<T>(this string input)
        {
            using var stream = new MemoryStream(Encoding.Unicode.GetBytes(input));
            var serializer = new DataContractJsonSerializer(typeof(T));
            return (T)serializer.ReadObject(stream);
        }

        public static string ToQueryString(this Arguments args)
        {
            var nvc = new NameValueCollection();

            foreach (var pi in args.GetType().GetProperties())
            {
                var value = pi.GetValue(args, null);
                if (value != null)
                {
                    nvc.Add(pi.Name.ToLowerInvariant(), value.ToString());
                }
            }

            return string.Join("&", nvc.AllKeys.Select(a => a + "=" + HttpUtility.UrlEncode(nvc[a])));
        }
    }
}