using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bunny.NET.Objets.Zone
{
    public class Zone
    {
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; } = 0;

        [JsonProperty("Domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; } = string.Empty;

        [JsonProperty("Records", NullValueHandling = NullValueHandling.Ignore)]
        public List<Record.Record> Records { get; set; } = new List<Record.Record>();

        [JsonProperty("DateModified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DateModified { get; set; } = DateTime.MinValue;

        [JsonProperty("DateCreated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DateCreated { get; set; } = DateTime.MinValue;

        [JsonProperty("NameserversDetected", NullValueHandling = NullValueHandling.Ignore)]
        public bool NameserversDetected { get; set; } = false;

        [JsonProperty("CustomNameserversEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool CustomNameserversEnabled { get; set; } = false;

        [JsonProperty("Nameserver1", NullValueHandling = NullValueHandling.Ignore)]
        public string Nameserver1 { get; set; } = string.Empty;

        [JsonProperty("Nameserver2", NullValueHandling = NullValueHandling.Ignore)]
        public string Nameserver2 { get; set; } = string.Empty;

        [JsonProperty("SoaEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string SoaEmail { get; set; } = string.Empty;

        [JsonProperty("NameserversNextCheck", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime NameserversNextCheck { get; set; } = new DateTime(1900, 01, 01);

        [JsonProperty("LoggingEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool LoggingEnabled { get; set; } = false;

        [JsonProperty("LoggingIPAnonymizationEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool LoggingIPAnonymizationEnabled { get; set; } = false;

        [JsonProperty("LogAnonymizationType", NullValueHandling = NullValueHandling.Ignore)]
        public int LogAnonymizationType { get; set; } = 0;
    }
}
