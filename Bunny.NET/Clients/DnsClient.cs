﻿using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Bunny.NET.Objets.Zone;
using Newtonsoft.Json;

namespace Bunny.NET.Clients
{
    public class DnsClient
    {
        private readonly string _token;

        public ZoneClient Zone { get; }

        public DnsClient(string apiKey)
        {
            _token = apiKey;
            Zone = new ZoneClient(_token);
        }

        public class ZoneClient
        {
            private readonly string _token;

            public ZoneClient(string token)
            {
                _token = token;
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

            public async Task<Zone> Create(string domain)
            {
                // Preparing raw
                string raw = $"{{ \"Domain\": \"{domain}\" }}";

                // Send
                string jsonResponse = await Core.SendPostRequest(_token, "/dnszone", raw);

                // Return
                return JsonConvert.DeserializeObject<Zone>(jsonResponse) ?? new Zone();
            }

            public async Task Delete(Zone zone)
            {
                // Send
                await Core.SendDeleteRequest(_token, $"/dnszone/{zone.Id}");
            }

            public async Task Delete(long zoneId)
            {
                // Send
                await Core.SendDeleteRequest(_token, $"/dnszone/{zoneId}");
            }
        }
    }
}