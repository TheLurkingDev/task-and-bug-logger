using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskAndBugLogger.Interfaces;
using TaskAndBugLogger.Models;

namespace TaskAndBugLogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkItemService _workItemService;

        public HomeController(IWorkItemService workItemService)
        {
            _workItemService = workItemService;
        }

        public IActionResult Index()
        {
            var workItems = _workItemService.GetAllWorkItems();
            return View(workItems);
        }

        public ActionResult AddWorkItem()
        {
            return RedirectToAction("AddItem", "AddWorkItem");
        }
    }
}
