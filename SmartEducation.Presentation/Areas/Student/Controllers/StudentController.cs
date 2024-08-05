using Microsoft.AspNetCore.Mvc;
using SmartEducation.Application.IEntityService.Student;

namespace SmartEducation.Presentation.Areas.Student.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentInfoService _StudentInfoService;
       
        public StudentController(IStudentInfoService StudentInfoService)
        {
            this._StudentInfoService = StudentInfoService;
        }


        public IActionResult Index()
        {
            _StudentInfoService.


            return View();
        }
    }
}
