using Bunny.NET.Clients;

namespace Bunny.NET
{
    public class BunnyClient
    {
        public string ApiKey { get; }

        public BunnyClient(string apiKey)
        {
            ApiKey = apiKey;

            Country = new CountryClient(apiKey);
            Dns = new DnsClient(apiKey);
            Region = new RegionClient(apiKey);
        }

        public CountryClient Country { get; }
        public DnsClient Dns { get; }
        public RegionClient Region { get; }
    }
}
