﻿using Microsoft.AspNetCore.Mvc;

namespace SmartEducation.Presentation.Areas.Account.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
