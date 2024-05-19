using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bunny.NET.Objets.Dns;
using Newtonsoft.Json;

namespace Bunny.NET.Clients
{
    public class DnsClient
    {
        public ZoneClient Zone { get; }
        public RecordClient Record { get; }

        public DnsClient(string token)
        {
            Zone = new ZoneClient(token);
            Record = new RecordClient(token);
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

            public async Task<Zone> Update(Zone zone)
            {
                // Preparing raw
                string raw = $"{{ \"CustomNameserversEnabled\": {(zone.CustomNameserversEnabled == true ? "true" : "false")}, \"Nameserver1\": \"{zone.Nameserver1}\", \"Nameserver2\": \"{zone.Nameserver2}\", \"SoaEmail\": \"{zone.SoaEmail}\", \"LoggingEnabled\": {(zone.LoggingEnabled == true ? "true" : "false")}, \"LogAnonymizationType\": {(long)zone.LogAnonymizationType}, \"LoggingIPAnonymizationEnabled\": {(zone.LoggingIPAnonymizationEnabled == true ? "true" : "false")} }}";

                // Send
                string jsonResponse = await Core.SendPostRequest(_token, $"/dnszone/{zone.Id}", raw);

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

        public class RecordClient
        {
            private readonly string _token;

            public RecordClient(string token)
            {
                _token = token;
            }

            public async Task<Record> Create(long? zoneId, Record record)
            {
                // Preparing raw
                string raw = JsonConvert.SerializeObject(record, Formatting.Indented);

                // Send
                string jsonResponse = await Core.SendPutRequest(_token, $"/dnszone/{zoneId}/records", raw);

                // Return
                return JsonConvert.DeserializeObject<Record>(jsonResponse) ?? new Record();
            }

            public async Task<List<Record>> List(long? zoneId)
            {
                // Send
                string jsonResponse = await Core.SendGetRequest(_token, $"/dnszone/{zoneId}");

                // Convert
                Zone zone = JsonConvert.DeserializeObject<Zone>(jsonResponse) ?? new Zone();

                // Get Record's
                List<Record> list = zone.Records;

                // Return
                return list;
            }

            public async Task<Record> Get(long? zoneId, long? recordId)
            {
                // Send
                string jsonResponse = await Core.SendGetRequest(_token, $"/dnszone/{zoneId}");

                // Convert
                Zone zone = JsonConvert.DeserializeObject<Zone>(jsonResponse) ?? new Zone();

                // Search
                if (zone.Records.Exists(x => x.Id == recordId) == false)
                {
                    throw new Exception($"DNS Record does not exist");
                }

                // Return
                return zone.Records.Single(x => x.Id == recordId);
            }

            public async Task Update(long? zoneId, Record record)
            {
                // Preparing raw
                string raw = JsonConvert.SerializeObject(record, Formatting.Indented);

                // Send
                await Core.SendPostRequest(_token, $"/dnszone/{zoneId}/records/{record.Id}", raw);
            }

            public async Task Delete(long? zoneId, long? recordId)
            {
                // Send
                await Core.SendDeleteRequest(_token, $"/dnszone/{zoneId}/records/{recordId}");
            }

            public async Task Delete(long zoneId, Record record)
            {
                // Send
                await Delete(zoneId, record.Id);
            }
        }
    }
}
