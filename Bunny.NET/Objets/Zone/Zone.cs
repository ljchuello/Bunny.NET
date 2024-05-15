using System;
using System.Collections.Generic;
using Bunny.NET.Enums;
using Newtonsoft.Json;

namespace Bunny.NET.Objets.Zone
{
    public class Zone
    {
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("Domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        [JsonProperty("Records", NullValueHandling = NullValueHandling.Ignore)]
        public List<Record.Record> Records { get; set; }

        [JsonProperty("DateModified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateModified { get; set; }

        [JsonProperty("DateCreated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("NameserversDetected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NameserversDetected { get; set; }

        [JsonProperty("CustomNameserversEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomNameserversEnabled { get; set; }

        [JsonProperty("Nameserver1", NullValueHandling = NullValueHandling.Ignore)]
        public string Nameserver1 { get; set; }

        [JsonProperty("Nameserver2", NullValueHandling = NullValueHandling.Ignore)]
        public string Nameserver2 { get; set; }

        [JsonProperty("SoaEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string SoaEmail { get; set; }

        [JsonProperty("NameserversNextCheck", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NameserversNextCheck { get; set; }

        [JsonProperty("LoggingEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoggingEnabled { get; set; }

        [JsonProperty("LoggingIPAnonymizationEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoggingIPAnonymizationEnabled { get; set; }

        [JsonProperty("LogAnonymizationType", NullValueHandling = NullValueHandling.Ignore)]
        public LogAnonymizationType? LogAnonymizationType { get; set; }
    }
}
