using Microsoft.AspNetCore.Mvc;
using SmartEducation.Application.IEntityService.Student;
using SmartEducation.Domain.Model.Student;

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
            IQueryable list_all_StudentInfo=_StudentInfoService.Get_All_StudentInfo();

            return View(list_all_StudentInfo);
        }

        public IActionResult Create(int? id)
        {
            StudentInfo obj_StudentInfo=new StudentInfo();
            if (id>0)
                obj_StudentInfo=_StudentInfoService.Get_StudentInfo(id??0);
            return View(obj_StudentInfo);
        }

        public async Task<IActionResult> Create(StudentInfo model)
        {
            string responseMsg=await _StudentInfoService.Save_StudentInfo(model);
            if (responseMsg=="success")
            return RedirectToAction("Index");
            return View(model);
        }


    }
}
