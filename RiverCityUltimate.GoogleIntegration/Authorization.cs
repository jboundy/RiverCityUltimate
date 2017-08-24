using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using Google.Apis.Util;
using RiverCityUltimate.Core;

namespace RiverCityUltimate.GoogleIntegration
{
    public class Authorization
    {
        public async Task<TokenResponse> ConfigureCredentials()
        {
            IClock clock = null;
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
                }
            });

            var tokenRequest = new TokenRequest
            {
                ClientId = Settings.GoogleConfig.ClientId,
                ClientSecret = Settings.GoogleConfig.ClientSecret,
                GrantType = "authorization_code"
            };

            return await tokenRequest.ExecuteAsync(new HttpClient
                {
                    BaseAddress = new Uri(Settings.GoogleConfig.AuthUri)
                },
                Settings.GoogleConfig.TokenUri, CancellationToken.None, clock);
        }
    }
}
