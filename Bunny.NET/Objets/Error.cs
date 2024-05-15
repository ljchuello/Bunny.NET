using Newtonsoft.Json;

namespace Bunny.NET.Objets
{
    public class Error
    {
        [JsonProperty("ErrorKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorKey { get; set; }

        [JsonProperty("Field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("Message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
}
