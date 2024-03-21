using Microsoft.AspNetCore.Mvc;
using NET_290_291_T35.Models;
using System.Diagnostics;

namespace NET_290_291_T35.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
