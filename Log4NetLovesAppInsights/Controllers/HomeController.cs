using log4net;
using Log4NetLovesAppInsights.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Log4NetLovesAppInsights.Controllers
{
    public class HomeController : Controller
    {
        ILog logger = LogManager.GetLogger("debug");

        public HomeController()
        {
            logger.Debug($"{nameof(HomeController)} instanciated.");
        }

        public IActionResult Index()
        {
            logger.Info("/Index");

            return View();
        }

        public IActionResult Privacy()
        {
            logger.Warn("Warn! Privacy zone!");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            logger.Error("Error action");

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
