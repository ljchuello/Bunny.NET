using System;
using Bunny.NET.DnsClient;
using Bunny.NET.Objets.Zone;

namespace Bunny.NET
{
    public class BunnyClient
    {
        public string ApiKey { get; }

        public BunnyClient(string apiKey)
        {
            ApiKey = apiKey;

            Zone = new ZoneClient(apiKey);
        }

        public ZoneClient Zone { get; }
    }
}
