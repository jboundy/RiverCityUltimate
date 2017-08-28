using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using Google.Apis.Sheets.v4;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using RiverCityUltimate.Core;

namespace RiverCityUltimate.GoogleIntegration
{
    public class Authorization
    {
        public IClock Clock { get; set; }

        //todo: figure out how to add authorization_code to the grant_type and where is that set at
        //todo: maybe offline access needs to be turned on?
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
                IncludeGrantedScopes = true,             
                HttpClientFactory = new HttpClientFactory()
            });

            var tokenResponse = await new TokenRequest().ExecuteAsync(flow.HttpClient, Settings.GoogleConfig.TokenUri, CancellationToken.None, Clock);

            return new UserCredential(flow, "user", tokenResponse);
        }
    }
}
