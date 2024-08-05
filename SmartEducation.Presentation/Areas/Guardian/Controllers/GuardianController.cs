using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Guardian.Controllers
{
    public class GuardianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
