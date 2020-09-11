using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ITunesTask.Search
{
    public class SearchProvider<T>
    {
        private string searchUrl = "https://itunes.apple.com/search";        

        public async Task<T> Search(string query)
        {
            string fullUrl = $"{searchUrl}?{query}";
            return await Get(fullUrl);
        }        
       
        private async Task<T> Get(string fullUrl)
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(fullUrl).ConfigureAwait(false);
            return result.Deserialize<T>();
        }
    }
}