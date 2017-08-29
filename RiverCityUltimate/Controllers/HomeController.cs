using System.Web.Mvc;

namespace RiverCityUltimate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult ScoreSchedules()
        {
            return View("Scores_Schedules");
        }

        public ActionResult Standings()
        {
            return View();
        }

        public ActionResult Store()
        {
            return View();
        }
    }
}