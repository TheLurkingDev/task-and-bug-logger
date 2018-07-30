using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskAndBugLogger.Interfaces;
using TaskAndBugLogger.Models;

namespace TaskAndBugLogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkItemService workItemService;

        public HomeController(IWorkItemService service)
        {
            workItemService = service;
        }

        public IActionResult Index()
        {
            var workItems = workItemService.GetAllWorkItems();
            return View(workItems);
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
