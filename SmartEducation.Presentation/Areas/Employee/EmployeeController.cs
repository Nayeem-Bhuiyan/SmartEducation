using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Employee
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
