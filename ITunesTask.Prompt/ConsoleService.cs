using System;
using ITunesTask.Search;

namespace ITunesTask.Prompt
{
    public class ConsoleService : InputService
    {
        public Arguments ReadArguments()
        {
            Console.WriteLine("\n---NEW SEARCH---");
            Console.WriteLine("Enter search term:");
            string term = Console.ReadLine();

            Console.WriteLine("Enter type: album, musicTrack, musicArtist, (default album)");
            string entity = Console.ReadLine();

            if (string.IsNullOrEmpty(entity))
            {
                entity = "album";
            }

            Console.WriteLine("Enter limit, default 10");
            string count = Console.ReadLine();
            int.TryParse(count, out int limit);

            if (limit == 0)
            {
                limit = 10;
            }

            return new Arguments()
            {
                Term = term,
                Limit = limit,
                Entity = entity
            };
        }
    }
}