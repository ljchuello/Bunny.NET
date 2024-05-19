using Bunny.NET.Enums;
using Bunny.NET.Objets.Dns;
using Record = Bunny.NET.Objets.Dns.Record;

namespace Bunny.NET.Tests
{
    public class DnsClientTest : IDisposable
    {
        private long _zoneId = 206930;

        private Zone _zoneCreateTrue;
        private Zone _zoneCreateFalse;
        private Zone _zoneEditTrue;

        private Record _recordCreateTrue;
        private Record _recordCreateFalse;
        private Record _recordEditTrue;

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
        public async Task DnsZoneUpdateTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);
            _zoneEditTrue = await bunnyClient.Dns.Zone.Create($"{Guid.NewGuid()}-xunit.com");

            // Act
            _zoneEditTrue.SoaEmail = "lalolanda@gmail.com";
            _zoneEditTrue.LoggingEnabled = true;
            _zoneEditTrue.LoggingIPAnonymizationEnabled = false;
            _zoneEditTrue = await bunnyClient.Dns.Zone.Update(_zoneEditTrue);

            // Assert
            Assert.True(_zoneEditTrue.Id > 0);
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

        [Fact]
        public async Task DnsRecordCreateTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);
            Record record = new Record();
            record.Name = "google.com";
            record.Value = "8.8.8.8";
            record.Type = RecordType.A;
            record.Ttl = 300;

            // Act
            _recordCreateTrue = await bunnyClient.Dns.Record.Create(_zoneId, record);

            // Assert
            Assert.True(_recordCreateTrue.Id > 0);
        }

        [Fact]
        public async Task DnsRecordCreateFalse()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);
            _recordCreateFalse = new Record();
            _recordCreateFalse.Name = "google.com";
            _recordCreateFalse.Value = "8.8.8.8";
            _recordCreateFalse.Type = RecordType.AAAA;
            _recordCreateFalse.Ttl = 300;

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await bunnyClient.Dns.Record.Create(_zoneId, _recordCreateFalse);
            });
        }

        [Fact]
        public async Task DnsRecordUpdateTrue()
        {
            // Arrange
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);
            Record record = new Record();
            record.Name = "google.com";
            record.Value = "8.8.8.8";
            record.Type = RecordType.A;
            record.Ttl = 300;
            _recordEditTrue = await bunnyClient.Dns.Record.Create(_zoneId, record);
            _recordEditTrue.Value = "8.8.4.4";
            _recordEditTrue.Ttl = 60;

            // Act
            await bunnyClient.Dns.Record.Update(_zoneId, _recordEditTrue);

            // Assert
            Assert.True(_recordEditTrue.Id > 0);
        }

        [Fact]
        public async Task DnsRecordDeleteTrue()
        {
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);
            Record record = new Record();
            record.Name = "google.com";
            record.Value = "8.8.8.8";
            record.Type = RecordType.A;
            record.Ttl = 300;
            record = await bunnyClient.Dns.Record.Create(_zoneId, record);

            // Act
            await bunnyClient.Dns.Record.Delete(_zoneId, record);

            // Assert
            Assert.True(true);
        }

        public async void Dispose()
        {
            BunnyClient bunnyClient = new BunnyClient(Config.ApiKey);

            if (_zoneCreateTrue != null)
                await bunnyClient.Dns.Zone.Delete(_zoneCreateTrue);

            if (_zoneCreateFalse != null)
                await bunnyClient.Dns.Zone.Delete(_zoneCreateFalse);

            if (_zoneEditTrue != null)
                await bunnyClient.Dns.Zone.Delete(_zoneCreateFalse);

            if (_recordCreateTrue != null)
                await bunnyClient.Dns.Record.Delete(_zoneId, _recordCreateTrue);

            if (_recordCreateFalse != null)
                await bunnyClient.Dns.Record.Delete(_zoneId, _recordCreateFalse);

            if (_recordEditTrue != null)
                await bunnyClient.Dns.Record.Delete(_zoneId, _recordEditTrue);

        }
    }
}