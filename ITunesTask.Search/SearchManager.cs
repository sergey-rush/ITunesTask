using System.Threading.Tasks;
using ITunesTask.Search.Models;
using Microsoft.Extensions.Caching.Memory;

namespace ITunesTask.Search
{
    public class SearchManager: CacheMemory
    {
        public async Task<ArtistResult> GetArtistsAsync(Arguments args)
        {
            ArtistResult artistResult;
            string key = args.ToQueryString();

            if (Cache.Get(key) != null)
            {
                artistResult = (ArtistResult)Cache.Get(key);
            }
            else
            {
                var searchProvider = new SearchProvider<ArtistResult>();
                artistResult = await searchProvider.Search(key);
                CacheData(key, artistResult);
            }

            return artistResult;
        }

        public async Task<SongResult> GetSongsAsync(Arguments args)
        {
            SongResult songResult;
            string key = args.ToQueryString();

            if (Cache.Get(key) != null)
            {
                songResult = (SongResult)Cache.Get(key);
            }
            else
            {
                var searchProvider = new SearchProvider<SongResult>();
                songResult = await searchProvider.Search(key);
                CacheData(key, songResult);
            }
            
            return songResult;
        }

        public async Task<AlbumResult> GetAlbumsAsync(Arguments args)
        {
            AlbumResult albumResult;
            string key = args.ToQueryString();

            if (Cache.Get(key) != null)
            {
                albumResult = (AlbumResult)Cache.Get(key);
            }
            else
            {
                var searchProvider = new SearchProvider<AlbumResult>();
                albumResult = await searchProvider.Search(key);
                CacheData(key, albumResult);
            }

            return albumResult;
        }
    }
}