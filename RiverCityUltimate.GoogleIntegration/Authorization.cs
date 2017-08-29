using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using Google.Apis.Util;
using RiverCityUltimate.Core;

namespace RiverCityUltimate.GoogleIntegration
{
    public class Authorization
    {
        public IClock Clock { get; set; }

        public async Task<UserCredential> ConfigureCredentials()
        {
            var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = Settings.GoogleConfig.ClientId,
                    ClientSecret = Settings.GoogleConfig.ClientSecret
                },
                Scopes = new[] {
                    DriveService.Scope.DriveFile,
                    DriveService.Scope.Drive,
                    SheetsService.Scope.SpreadsheetsReadonly
                },
                IncludeGrantedScopes = true
            });

            var tokenRequest = new TokenRequest
            {
                ClientId = Settings.GoogleConfig.ClientId,
                ClientSecret = Settings.GoogleConfig.ClientSecret,
                GrantType = "authorization_code"
            };

            var tokenResponse = await tokenRequest.ExecuteAsync(flow.HttpClient, Settings.GoogleConfig.TokenUri, CancellationToken.None, Clock);

            return new UserCredential(flow, "user", tokenResponse);
        }
    }
}
