using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using TaskAndBugLogger.Data;
using TaskAndBugLogger.Models;

namespace TaskAndBugLogger.Controllers
{
    public class HomeController : Controller
    {
        public Data.MongoDBRepository mongoDBRepo;

        public HomeController(IOptions<Settings> settings)
        {
            mongoDBRepo = new MongoDBRepository(settings);
        }

        public IActionResult Index()
        {
            return Json(mongoDBRepo.Database.Client.Cluster.Description);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
