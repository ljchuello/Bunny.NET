using Bunny.NET;

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
                BunnyClient _bunnyClient = new BunnyClient(File.ReadAllText("D:\\BunnyNET.txt"));
                var a = await _bunnyClient.Zone.Get(202199);
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
