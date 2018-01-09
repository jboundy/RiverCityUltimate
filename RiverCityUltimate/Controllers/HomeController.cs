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