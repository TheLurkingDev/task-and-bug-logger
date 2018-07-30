using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskAndBugLogger.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace TaskAndBugLogger.Controllers
{
    public class HomeController : Controller
    {
        IMongoDatabase _database;

        public HomeController(IOptions<Settings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.ConnectionString);
            _database = mongoClient.GetDatabase(settings.Value.Database);
        }

        public IActionResult Index()
        {
            return Json(_database.Client.Cluster.Description);
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
