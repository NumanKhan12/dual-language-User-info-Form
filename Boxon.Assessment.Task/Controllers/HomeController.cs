using Boxon.Assessment.Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Boxon.Assessment.Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult UserInfoForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserInfoForm(UserRecord model)
        {
            return View();
        }
   
    }
}