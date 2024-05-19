using Bunny.NET;
using Bunny.NET.Objets.Dns;

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

                long zoneId = 206492;
                long recordId = 3833193;

                // Get
                Record record = await bunnyClient.Dns.Record.Get(zoneId, recordId);

                // Delete
                await bunnyClient.Dns.Record.Delete(zoneId, record);
                await bunnyClient.Dns.Record.Delete(zoneId, recordId);
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
