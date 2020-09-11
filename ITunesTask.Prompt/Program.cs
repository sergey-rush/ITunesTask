using System;
using ITunesTask.Search;

namespace ITunesTask.Prompt
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    InputService inputService = new ConsoleService();
                    Arguments args = inputService.ReadArguments();
                    ISearch search = new SearchService();
                    PrintService.Print(search.Fetch(args));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}