using System.IO;
using FluentAssertions;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using RiverCityUltimate.Core;
using Xunit;

namespace RiverCityUltimate.GoogleIntegration.Tests
{
    public class FileSerializationTests
    {
        private DriveService _drive;
        public FileSerializationTests()
        {
            Settings.Initialize();
            var auth = new Authorization();
            _drive = new DriveService(new BaseClientService.Initializer
            {
                ApiKey = Settings.GoogleConfig.ApiKey,
                HttpClientInitializer = auth.ServiceAccount
            });
        }

        [Fact]
        public void GetFile()
        {
            var stream = new MemoryStream();
            var service = new FileSerializer(_drive, new SheetsService());
            var docRequest = service.GetDoc("1GXgo5vhokYYspZc41ad2A3tmvQVHT4PbSZ0PHQo59oc");
            var doc = service.FileStream(docRequest, stream).Result;
            doc.Should().NotBeNull();
        }
    }
}
