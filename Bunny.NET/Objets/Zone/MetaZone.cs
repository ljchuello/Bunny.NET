using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunny.NET.Objets.Zone
{
    public class MetaZone
    {
        [JsonProperty("Items")]
        public List<Zone> Items { get; set; }

        [JsonProperty("CurrentPage")]
        public int CurrentPage { get; set; } 

        [JsonProperty("TotalItems")]
        public int TotalItems { get; set; } 

        [JsonProperty("HasMoreItems")]
        public bool HasMoreItems { get; set; }
    }
}
