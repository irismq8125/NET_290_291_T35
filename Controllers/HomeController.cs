using Microsoft.AspNetCore.Mvc;
using NET_290_291_T35.Models;
using NET_290_291_T35.Models.ToDoTask;
using System.Diagnostics;

namespace NET_290_291_T35.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<ToDoTask> toDoTasks;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            toDoTasks = new List<ToDoTask>();
            return View(toDoTasks);
        }
    }
}
