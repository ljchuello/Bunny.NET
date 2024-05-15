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
                BunnyClient bunnyClient = new BunnyClient(await File.ReadAllTextAsync("D:\\BunnyNET.txt"));

                // Get
                Zone zone = await bunnyClient.Dns.Zone.Get(204058);

                // Set
                zone.SoaEmail = "ljchuello@gmail.com";
                zone.LoggingEnabled = true;
                zone.LoggingIPAnonymizationEnabled = false;

                // Update
                zone = await bunnyClient.Dns.Zone.Update(zone);
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
