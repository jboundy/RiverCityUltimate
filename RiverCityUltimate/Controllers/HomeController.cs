using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using RiverCityUltimate.Core;
using RiverCityUltimate.GoogleIntegration;

namespace RiverCityUltimate.Controllers
{
    public class HomeController : Controller
    {
        private Authorization _authFlow;
        private FileSerializer _fileSerializer;

        public HomeController()
        {
            //_authFlow = new Authorization();
            //var driveService = new DriveService(new BaseClientService.Initializer
            //{
            //    ApiKey = Settings.GoogleConfig.ApiKey
            //});
            //_fileSerializer = new FileSerializer(driveService, new SheetsService());
        }
        public async Task<ActionResult> Index()
        {
            //var result = await new AuthorizationCodeMvcApp(this, _authFlow).AuthorizeAsync(CancellationToken.None);

            //if (result.Credential != null)
            //{
            //    var stream = new MemoryStream();
            //    var docRequest =_fileSerializer.GetDoc("1GXgo5vhokYYspZc41ad2A3tmvQVHT4PbSZ0PHQo59oc");
            //    var doc = await _fileSerializer.FileStream(docRequest, stream);
            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Title = "Registration";
            return View();
        }

        public ActionResult ScoreSchedules()
        {
            ViewBag.Title = "Scores & Schedules";
            return View("Scores_Schedules");
        }

        public ActionResult Standings()
        {
            ViewBag.Title = "Standings";
            return View();
        }

        public ActionResult Store()
        {
            ViewBag.Title = "Store";
            return View();
        }
    }
}