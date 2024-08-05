using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Exam.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
