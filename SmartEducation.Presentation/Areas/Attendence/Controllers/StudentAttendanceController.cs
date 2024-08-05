using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Attendence.Controllers
{
    public class StudentAttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
