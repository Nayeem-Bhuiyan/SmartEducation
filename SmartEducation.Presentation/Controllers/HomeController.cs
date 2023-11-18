using Microsoft.AspNetCore.Mvc;
using SmartEducation.Presentation.Constant;
using SmartEducation.Presentation.Models;
using System.Diagnostics;

namespace SmartEducation.Presentation.Controllers
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

        public IActionResult Privacy()
        {
            #region Get Session Object
            var sessionObj = HttpContext.Session.Get<SmartSession>("SmartSession");
            #endregion
            if (sessionObj!=null)
            {
                ViewBag.SmartSessionData=sessionObj;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
