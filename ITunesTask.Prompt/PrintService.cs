using System;
using System.Collections.Generic;
using System.Text;
using ITunesTask.Search.Models;

namespace ITunesTask.Prompt
{
    public static class PrintService
    {
        public static void Print(object obj)
        {
            Console.WriteLine("\nOutput:");

            if (obj is SongResult songResult)
            {
                PrintSongResult(songResult);
            }

            if (obj is ArtistResult artistResult)
            {
                PrintArtistResult(artistResult);
            }

            if (obj is AlbumResult albumResult)
            {
                PrintAlbumResult(albumResult);
            }            
        }

        private static void PrintSongResult(SongResult songResult)
        {
            foreach (var item in songResult.Songs)
            {
                Console.WriteLine("Id: {0} Song: {1} Album: {2} Artist: {3}", item.ArtistId, item.TrackCensoredName, item.CollectionName, item.ArtistName);
            }
        }

        private static void PrintArtistResult(ArtistResult artistResult)
        {
            foreach (var item in artistResult.Artists)
            {
                Console.WriteLine("Id: {0} Name: {1} Genre: {2}", item.ArtistId, item.ArtistName, item.PrimaryGenreName);
            }
        }

        private static void PrintAlbumResult(AlbumResult albumResult)
        {
            foreach (var item in albumResult.Albums)
            {
                Console.WriteLine("Id: {0} Artist: {1} Album: {2}", item.ArtistId, item.ArtistName, item.CollectionName);
            }
        }
    }
}
