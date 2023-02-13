using CI_Plateform_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_Plateform_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult login()
        {
            return View();
        }
        public IActionResult ForgotPsd()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult NewPassword()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}