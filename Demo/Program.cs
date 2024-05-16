using Bunny.NET;
using Bunny.NET.Enums;
using Bunny.NET.Objets;
using Bunny.NET.Objets.Dns;
using Bunny.NET.Objets.Region;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            try
            {
                BunnyClient bunnyClient = new BunnyClient(await File.ReadAllTextAsync("D:\\BunnyNET.txt"));

                List<Country> list = await bunnyClient.Country.List();

                // Get
                Zone zone = await bunnyClient.Dns.Zone.Get(204058);

                // Set
                Record record = new Record();
                record.Type = RecordType.A;
                record.Ttl = 300;
                record.Value = "8.8.8.8";
                record.Name = "google";
                record.EnviromentalVariables = new List<EnviromentalVariable>();
                record.EnviromentalVariables.Add(new EnviromentalVariable { Name = "Lalo", Value = "Landa" });
                record.EnviromentalVariables.Add(new EnviromentalVariable { Name = "Leonardo", Value = "Chuello" });

                // Create
                record = await bunnyClient.Dns.Record.Create(zone.Id, record);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("Finish");
                Console.ReadLine();
            }
        }
    }
}
