using System.Collections.Generic;
using Bunny.NET.Enums;
using Newtonsoft.Json;

namespace Bunny.NET.Objets.Record
{
    public class Record
    {
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public RecordType? Type { get; set; }

        [JsonProperty("Ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("Weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        [JsonProperty("Priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        [JsonProperty("Port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        [JsonProperty("Flags", NullValueHandling = NullValueHandling.Ignore)]
        public int? Flags { get; set; }

        [JsonProperty("Tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        [JsonProperty("Accelerated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accelerated { get; set; }

        [JsonProperty("AcceleratedPullZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AcceleratedPullZoneId { get; set; }

        [JsonProperty("LinkName", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkName { get; set; }

        [JsonProperty("IPGeoLocationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public IPGeoLocationInfo IPGeoLocationInfo { get; set; }

        [JsonProperty("GeolocationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public GeolocationInfo GeolocationInfo { get; set; }

        [JsonProperty("MonitorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorStatus { get; set; }

        [JsonProperty("MonitorType", NullValueHandling = NullValueHandling.Ignore)]
        public MonitorType? MonitorType { get; set; }

        [JsonProperty("GeolocationLatitude", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? GeolocationLatitude { get; set; }

        [JsonProperty("GeolocationLongitude", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? GeolocationLongitude { get; set; }

        [JsonProperty("EnviromentalVariables", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnviromentalVariable> EnviromentalVariables { get; set; }

        [JsonProperty("LatencyZone", NullValueHandling = NullValueHandling.Ignore)]
        public string LatencyZone { get; set; }

        [JsonProperty("SmartRoutingType", NullValueHandling = NullValueHandling.Ignore)]
        public SmartRoutingType? SmartRoutingType { get; set; }

        [JsonProperty("Disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        [JsonProperty("Comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }
    }

    public class IPGeoLocationInfo
    {
        [JsonProperty("CountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("ASN", NullValueHandling = NullValueHandling.Ignore)]
        public int? ASN { get; set; }

        [JsonProperty("OrganizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }
    }

    public class GeolocationInfo
    {
        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("Latitude", NullValueHandling = NullValueHandling.Ignore)]
        public int? Latitude { get; set; }

        [JsonProperty("Longitude", NullValueHandling = NullValueHandling.Ignore)]
        public int? Longitude { get; set; }
    }

    public class EnviromentalVariable
    {
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
