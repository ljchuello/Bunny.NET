using Newtonsoft.Json;

namespace Bunny.NET.Objets.Region
{
    public class Region
    {
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("PricePerGigabyte", NullValueHandling = NullValueHandling.Ignore)]
        public double? PricePerGigabyte { get; set; }

        [JsonProperty("RegionCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        [JsonProperty("ContinentCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ContinentCode { get; set; }

        [JsonProperty("CountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        [JsonProperty("Latitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty("Longitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        [JsonProperty("AllowLatencyRouting", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowLatencyRouting { get; set; }
    }
}
