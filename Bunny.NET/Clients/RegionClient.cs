using System.Collections.Generic;
using System.Threading.Tasks;
using Bunny.NET.Objets.Region;
using Newtonsoft.Json;

namespace Bunny.NET.Clients
{
    public class RegionClient
    {
        private readonly string _token;

        public RegionClient(string token)
        {
            _token = token;
        }

        public async Task<List<Region>> List()
        {
            // Init
            List<Region> list = new List<Region>();

            // Get
            string json = await Core.SendGetRequest(_token, $"/region");
            list = JsonConvert.DeserializeObject<List<Region>>(json);

            // Free
            return list;
        }
    }
}
