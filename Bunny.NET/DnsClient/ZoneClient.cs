using System.Collections.Generic;
using System.Threading.Tasks;
using Bunny.NET.Objets.Zone;
using Newtonsoft.Json;

namespace Bunny.NET.DnsClient
{
    public class ZoneClient
    {
        private readonly string _token;

        public ZoneClient(string apiKey)
        {
            _token = apiKey;
        }

        public async Task<List<Zone>> List()
        {
            long page = 0;
            List<Zone> list = new List<Zone>();

            while (true)
            {
                // Next
                page++;
                MetaZone metaZone = JsonConvert.DeserializeObject<MetaZone>(await Core.SendGetRequest(_token, $"/dnszone?page={page}&perPage={Core.PerPage}"));

                // Add
                foreach (var row in metaZone.Items)
                    list.Add(row);

                // Continue?
                if (metaZone.HasMoreItems == false)
                    break;
            }

            // Free
            return list;
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
