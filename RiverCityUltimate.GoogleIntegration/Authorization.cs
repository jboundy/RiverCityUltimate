using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using RiverCityUltimate.Core;

namespace RiverCityUltimate.GoogleIntegration
{
    public class Authorization
    {
        public async Task<FilesResource.ExportRequest> ExportRequestAsync()
        {
            string[] scopes = { DriveService.Scope.DriveFile, DriveService.Scope.Drive };

            var clientSecrets = new ClientSecrets
            {
                ClientId = Settings.GoogleConfig.ClientId,
                ClientSecret = Settings.GoogleConfig.ClientSecret
            };
            
            //todo: find some other way to get the credentials. Might just use a standard httprequest to the endpoint
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(clientSecrets, scopes , "user", CancellationToken.None );

            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = Settings.GoogleConfig.ProjectId
            });

            return service.Files.Export(Settings.GoogleConfig.FileId, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
    }
}
