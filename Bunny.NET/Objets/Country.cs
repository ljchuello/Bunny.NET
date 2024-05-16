using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bunny.NET.Objets
{
    public class Country
    {
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("IsoCode", NullValueHandling = NullValueHandling.Ignore)]
        public string IsoCode { get; set; }

        [JsonProperty("IsEU", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEU { get; set; }

        [JsonProperty("TaxRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? TaxRate { get; set; }

        [JsonProperty("TaxPrefix", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxPrefix { get; set; }

        [JsonProperty("FlagUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string FlagUrl { get; set; }

        [JsonProperty("PopList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PopList { get; set; }
    }
}
