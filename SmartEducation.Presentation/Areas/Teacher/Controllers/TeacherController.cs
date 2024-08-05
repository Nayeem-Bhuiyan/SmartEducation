using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Teacher.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
