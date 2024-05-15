using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bunny.NET.Objets.Dns
{
    public class MetaZone
    {
        [JsonProperty("Items")]
        public List<Zone> Items { get; set; }

        [JsonProperty("CurrentPage")]
        public long CurrentPage { get; set; } 

        [JsonProperty("TotalItems")]
        public long TotalItems { get; set; } 

        [JsonProperty("HasMoreItems")]
        public bool HasMoreItems { get; set; }
    }
}
