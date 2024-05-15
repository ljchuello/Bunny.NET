using Bunny.NET.Objets.Region;

namespace Bunny.NET.Tests
{
    public class RegionClientTest
    {
        [Fact]
        public async Task DnsZoneCreateTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);

            // Act
            List<Region> listRegion = await bunnyClient.Region.List();

            // Assert
            Assert.True(listRegion.Count > 1);
        }
    }
}
