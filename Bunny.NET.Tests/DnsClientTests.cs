using Bunny.NET.Objets.Zone;

namespace Bunny.NET.Tests
{
    public class DnsClientTests : IDisposable
    {
        private Zone _zoneCreateTrue;
        private Zone _zoneCreateFalse;
        private Zone _zoneEdit;

        [Fact]
        public async Task DnsZoneCreateTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);

            // Act
            _zoneCreateTrue = await bunnyClient.Dns.Zone.Create($"{Guid.NewGuid()}-xunit.com");

            // Assert
            Assert.True(_zoneCreateTrue.Id > 0);
        }

        [Fact]
        public async Task DnsZoneCreateFalse()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient("errorInApiKey");

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () =>
            {
                _zoneCreateFalse = await bunnyClient.Dns.Zone.Create($"{Guid.NewGuid()}-xunit.com");
            });
        }

        [Fact]
        public async Task DnsZoneDeleteTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);
            Zone zoneDelete = await bunnyClient.Dns.Zone.Create($"{Guid.NewGuid()}-xunit.com");

            // Act
            await bunnyClient.Dns.Zone.Delete(zoneDelete);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public async Task DnsZoneDeleteFalse()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient("errorInApiKey");

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await bunnyClient.Dns.Zone.Delete(5);
            });
        }

        public async void Dispose()
        {
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);

            if (_zoneCreateTrue != null)
                await bunnyClient.Dns.Zone.Delete(_zoneCreateTrue);

            if (_zoneCreateFalse != null)
                await bunnyClient.Dns.Zone.Delete(_zoneCreateFalse);
        }
    }
}