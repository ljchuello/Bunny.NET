using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bunny.NET.Objets;

namespace Bunny.NET.Clients
{
    public class CountryClient
    {
        private readonly string _token;

        public CountryClient(string token)
        {
            _token = token;
        }

        public async Task<List<Country>> List()
        {
            // Init
            List<Country> list = new List<Country>();

            // Get
            string json = await Core.SendGetRequest(_token, $"/country");
            list = JsonConvert.DeserializeObject<List<Country>>(json);

            // Free
            return list;
        }
    }
}
