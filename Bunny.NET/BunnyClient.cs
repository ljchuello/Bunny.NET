using Bunny.NET.Clients;

namespace Bunny.NET
{
    public class BunnyClient
    {
        public string ApiKey { get; }

        public BunnyClient(string apiKey)
        {
            ApiKey = apiKey;

            Dns = new DnsClient(apiKey);
            Region = new RegionClient(apiKey);
        }

        public DnsClient Dns { get; }
        public RegionClient Region { get; }
    }
}
