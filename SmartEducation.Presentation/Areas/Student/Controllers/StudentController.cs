﻿using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Student.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
