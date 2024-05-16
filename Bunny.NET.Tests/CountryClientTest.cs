using Bunny.NET.Objets;

namespace Bunny.NET.Tests
{
    public class CountryClientTest
    {
        [Fact]
        public async Task CountryListTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);

            // Act
            List<Country> listCountry = await bunnyClient.Country.List();

            // Assert
            Assert.True(listCountry.Count > 1);
        }
    }
}
