using Microsoft.AspNetCore.Mvc;
using SmartEducation.Presentation.Areas.Auth.Models;
using SmartEducation.Presentation.Constant;

namespace SmartEducation.Presentation.Areas.Auth.Controllers
{
    public class SessionTestController : Controller
    {
        public IActionResult Login()
        {


            #region TestData
            VmLogin vmLogin = new VmLogin();
            vmLogin.UserName="Nayeem";
            vmLogin.Email="nayeem@gmail.com";
            vmLogin.Password="123456";
            #endregion

            //After successful login operation.Create new session Object
            #region Set Session Object
            var objSmartSession = new SmartSession();
            objSmartSession.UserName = vmLogin.UserName;
            objSmartSession.Email = vmLogin.Email;
            objSmartSession.UserCode = "123454";

            HttpContext.Session.Set("SmartSession", objSmartSession); //"SessionHelper" it can be any custom name
            #endregion

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(VmLogin vmLogin)
        {
            #region TestData
            vmLogin.UserName="Nayeem";
            vmLogin.Email="nayeem@gmail.com";
            vmLogin.Password="123456";
            #endregion

            //After successful login operation.Create new session Object
            #region Set Session Object
            var objSmartSession = new SmartSession();
            objSmartSession.UserName = vmLogin.UserName;

            HttpContext.Session.Set("SessionHelper", objSmartSession); //"SessionHelper" it can be any custom name
            #endregion

            #region Get Session Object
            var sessionObj = HttpContext.Session.Get<SmartSession>("SessionHelper");
            #endregion

            return View();
        }
    }
}
