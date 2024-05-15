using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bunny.NET.Objets.Record
{
    public class Record
    {
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; } = 0;

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; } = 0;

        [JsonProperty("Ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int Ttl { get; set; } = 0;

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; } = string.Empty;

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("Weight", NullValueHandling = NullValueHandling.Ignore)]
        public int Weight { get; set; } = 0;

        [JsonProperty("Priority", NullValueHandling = NullValueHandling.Ignore)]
        public int Priority { get; set; } = 0;

        [JsonProperty("Port", NullValueHandling = NullValueHandling.Ignore)]
        public int Port { get; set; } = 0;

        [JsonProperty("Flags", NullValueHandling = NullValueHandling.Ignore)]
        public int Flags { get; set; } = 0;

        [JsonProperty("Tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; } = string.Empty;

        [JsonProperty("Accelerated", NullValueHandling = NullValueHandling.Ignore)]
        public bool Accelerated { get; set; } = false;

        [JsonProperty("AcceleratedPullZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public int AcceleratedPullZoneId { get; set; } = 0;

        [JsonProperty("LinkName", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkName { get; set; } = string.Empty;

        [JsonProperty("IPGeoLocationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public IPGeoLocationInfo IPGeoLocationInfo { get; set; } = new IPGeoLocationInfo();

        [JsonProperty("GeolocationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public GeolocationInfo GeolocationInfo { get; set; } = new GeolocationInfo();

        [JsonProperty("MonitorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public int MonitorStatus { get; set; } = 0;

        [JsonProperty("MonitorType", NullValueHandling = NullValueHandling.Ignore)]
        public int MonitorType { get; set; } = 0;

        [JsonProperty("GeolocationLatitude", NullValueHandling = NullValueHandling.Ignore)]
        public int GeolocationLatitude { get; set; } = 0;

        [JsonProperty("GeolocationLongitude", NullValueHandling = NullValueHandling.Ignore)]
        public int GeolocationLongitude { get; set; } = 0;

        [JsonProperty("EnviromentalVariables", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnviromentalVariable> EnviromentalVariables { get; set; } = new List<EnviromentalVariable>();

        [JsonProperty("LatencyZone", NullValueHandling = NullValueHandling.Ignore)]
        public string LatencyZone { get; set; } = string.Empty;

        [JsonProperty("SmartRoutingType", NullValueHandling = NullValueHandling.Ignore)]
        public int SmartRoutingType { get; set; } = 0;

        [JsonProperty("Disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool Disabled { get; set; } = false;

        [JsonProperty("Comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; } = string.Empty;
    }

    public class IPGeoLocationInfo
    {
        [JsonProperty("CountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; } = string.Empty;

        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; } = string.Empty;

        [JsonProperty("ASN", NullValueHandling = NullValueHandling.Ignore)]
        public int ASN { get; set; } = 0;

        [JsonProperty("OrganizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; } = string.Empty;

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; } = string.Empty;
    }

    public class GeolocationInfo
    {
        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; } = string.Empty;

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; } = string.Empty;

        [JsonProperty("Latitude", NullValueHandling = NullValueHandling.Ignore)]
        public int Latitude { get; set; } = 0;

        [JsonProperty("Longitude", NullValueHandling = NullValueHandling.Ignore)]
        public int Longitude { get; set; } = 0;
    }

    public class EnviromentalVariable
    {
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; } = string.Empty;
    }
}
