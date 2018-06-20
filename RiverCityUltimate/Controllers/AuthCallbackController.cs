using Google.Apis.Auth.OAuth2.Mvc;
using RiverCityUltimate.GoogleIntegration;

namespace RiverCityUltimate.Controllers
{
    public class AuthCallbackController : Google.Apis.Auth.OAuth2.Mvc.Controllers.AuthCallbackController
    {
        protected override FlowMetadata FlowData
        {
            get { return new Authorization(); }
        } 
    }
}