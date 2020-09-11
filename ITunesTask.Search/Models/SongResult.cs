using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ITunesTask.Search.Models
{
    [DataContract]
    public class SongResult
    {
        [DataMember(Name = "resultCount")]
        public int Count { get; set; }

        [DataMember(Name = "results")]
        public List<Song> Songs { get; set; }
    }
}
