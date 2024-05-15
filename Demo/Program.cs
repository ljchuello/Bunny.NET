using Bunny.NET;
using Bunny.NET.Objets.Zone;

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
                BunnyClient _bunnyClient = new BunnyClient(await File.ReadAllTextAsync("D:\\BunnyNET.txt"));

                // Get
                List<Zone> listZone = await _bunnyClient.Dns.Zone.List();

                foreach (Zone zone in listZone)
                {
                    Console.WriteLine($"Eliminar {zone.Domain}? Y/n");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        await _bunnyClient.Dns.Zone.Delete(zone);
                    }
                }
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
