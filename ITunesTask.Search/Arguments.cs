namespace ITunesTask.Search
{
    public class Arguments
    {
        /// <summary>
        /// Artist Id
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// All Music Guide (AMG) ID
        /// </summary>
        public long? AmgArtistId { get; set; }

        /// <summary>
        /// Search clause
        /// </summary>
        public string Term { get; set; }

        /// <summary>
        /// music, podcast, tvShow, 
        /// </summary>
        public string Media { get; set; } = "music";

        /// <summary>
        /// album, musicArtist, musicTrack, tvEpisode, tvSeason
        /// </summary>
        public string Entity { get; set; } = "album";

        /// <summary>
        /// us, gb, ru
        /// https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2
        /// </summary>
        public string Country { get; set; } = "us";

        /// <summary>
        /// Result limitation
        /// </summary>
        public int Limit { get; set; } = 10;
    }
}