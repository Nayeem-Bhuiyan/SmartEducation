using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Event.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
