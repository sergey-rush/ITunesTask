using System;
using System.Collections.Generic;
using ITunesTask.Search;

namespace ITunesTask.Prompt
{
    public class SearchService : ISearch
    {
        public void OnValidate(Arguments args)
        {
            if (string.IsNullOrEmpty(args.Term))
            {
                DisplayError(args);
                throw new ArgumentNullException(nameof(args.Term));
            }

            if (args.Limit < 0)
            {
                DisplayError(args);
                throw new ArgumentOutOfRangeException(nameof(args.Limit));
            }
        }

        public void DisplayError(Arguments args)
        {
            Console.WriteLine("OnValidate: Term-{0} Type-{1} Limit-{2}", args.Term, args.Entity, args.Limit);
        }

        public object Fetch(Arguments args)
        {
            OnValidate(args);

            SearchManager searchManager = new SearchManager();
            switch (args.Entity)
            {
                case "album":
                    return searchManager.GetAlbumsAsync(args).Result;
                case "musicTrack":
                    return searchManager.GetSongsAsync(args).Result;
                case "musicArtist":
                    return searchManager.GetArtistsAsync(args).Result;
                default:
                    DisplayError(args);
                    throw new ArgumentOutOfRangeException("Type");
            }
        }
    }
}