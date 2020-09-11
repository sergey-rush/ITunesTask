using System.Linq;
using ITunesTask.Search;
using Xunit;

namespace ITunesTask.Tests
{
    public class SearchTests
    {
        private readonly SearchManager searchManager = new SearchManager();

        [Fact]
        public void GetSongTest()
        {
            Arguments args = new Arguments();
            args.Term = "Paradise";
            args.Entity = "musicTrack";
            var items = searchManager.GetSongsAsync(args).Result;
            Assert.True(items.Songs.Any());
        }

        [Fact]
        public void GetArtistTest()
        {
            Arguments args = new Arguments();
            args.Term = "Sade";
            args.Entity = "musicArtist";
            var items = searchManager.GetArtistsAsync(args).Result;
            Assert.True(items.Artists.Any());
        }

        [Fact]
        public void GetAlbumTest()
        {
            Arguments args = new Arguments();
            args.Term = "Promise";
            args.Entity = "album";
            var items = searchManager.GetAlbumsAsync(args).Result;
            Assert.True(items.Albums.Any());
        }
    }
}