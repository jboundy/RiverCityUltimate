using System;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using RiverCityUltimate.Core;

namespace RiverCityUltimate.GoogleIntegration
{
    public class Authorization : FlowMetadata
    {
        public override IAuthorizationCodeFlow Flow { get; }
        public ServiceAccountCredential ServiceAccount { get; set; }
        public Authorization()
        {
            Flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = Settings.GoogleConfig.OAuthClientId,
                    ClientSecret = Settings.GoogleConfig.OAuthClientSecret
                },
                Scopes = Scopes()
                });

            ServiceAccount = new ServiceAccountCredential(
                new ServiceAccountCredential.Initializer(Settings.GoogleConfig.ClientEmail)
                {
                    Scopes = Scopes()
                }.FromPrivateKey($@"{Settings.GoogleConfig.PrivateKey}"));

            //ResponseToken = new AuthorizationCodeTokenRequest
            //{
            //    ClientId = Settings.GoogleConfig.ClientId,
            //    ClientSecret = Settings.GoogleConfig.PrivateKey,
            //    Code = Settings.GoogleConfig.AuthorizationCode,
            //    GrantType = Settings.GoogleConfig.
            //}.ExecuteAsync(new HttpClient
            //    {
            //        BaseAddress = new Uri(Settings.GoogleConfig.AuthUri)
            //    }, 
            //    Settings.GoogleConfig.TokenUri, CancellationToken.None, Clock).Result;

        }

        private string[] Scopes()
        {
            return new[]
            {
                DriveService.Scope.DriveFile,
                DriveService.Scope.Drive,
                SheetsService.Scope.SpreadsheetsReadonly
            };
        }

        public override string GetUserId(Controller controller)
        {
            return "user";
        }
    }
}
