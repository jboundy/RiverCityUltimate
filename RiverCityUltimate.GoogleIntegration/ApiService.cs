using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using RiverCityUltimate.Core;

namespace RiverCityUltimate.GoogleIntegration
{
    public class ApiService
    {
        public DriveService DriveService;
        public SheetsService SheetService;
        public void ConfigureServices(UserCredential credentials)
        {
            DriveService = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credentials,
                ApplicationName = Settings.GoogleConfig.ProjectId
            });

            SheetService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credentials,
                ApplicationName = Settings.GoogleConfig.ProjectId
            });

        }
    }
}
