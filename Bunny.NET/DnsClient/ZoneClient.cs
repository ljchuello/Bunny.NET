using System.Threading.Tasks;
using Bunny.NET.Objets.Zone;
using Newtonsoft.Json;

namespace Bunny.NET.DnsClient
{
    public class ZoneClient
    {
        private string _token;

        public ZoneClient(string apiKey)
        {
            _token = apiKey;
        }

        public async Task<Zone> Get(long id)
        {
            // Send
            string json = await Core.SendGetRequest(_token, $"/dnszone/{id}");

            // Get
            Zone zone = JsonConvert.DeserializeObject<Zone>(json);

            // Free
            return zone;
        }
    }
}
