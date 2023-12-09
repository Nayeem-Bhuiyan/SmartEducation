using MailKit;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEducation.Application.IEntityService.Auth;
using SmartEducation.Application.ViewModel.Auth;
using SmartEducation.Domain.Model.Auth;
using SmartEducation.Domain.Model.MasterPanel;
using SmartEducation.Presentation.Areas.Auth.Models;
using SmartEducation.Presentation.Constant;
using System.Net;

namespace SmartEducation.Presentation.Areas.Auth.Controllers
{
    [Authorize]
    [Area("Auth")]
    public class UserAccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        private readonly IPasswordValidator<ApplicationUser> _passwordValidator;
        private readonly IUserValidator<ApplicationUser> _userValidator;
        private readonly ILogger<RegisterViewModel> _logger;
        private readonly IMailService _mailService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IWebHostEnvironment _environment;
        public readonly IApplicationUserService _applicationUserService;
        public UserAccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager,
            IPasswordHasher<ApplicationUser> passwordHash,
            IPasswordValidator<ApplicationUser> passwordVal,
            IUserValidator<ApplicationUser> userValid,
            ILogger<RegisterViewModel> logger,
            IMailService mailService,
            IHttpContextAccessor httpContextAccessor,
            IWebHostEnvironment environment,
            IApplicationUserService applicationUserService
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _passwordHasher = passwordHash;
            _passwordValidator = passwordVal;
            _userValidator = userValid;
            _logger = logger;
            _mailService = mailService;
            _httpContextAccessor = httpContextAccessor;
            _environment = environment;
            _applicationUserService = applicationUserService;
        }


        #region Register
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            //ViewBag.Countries = await _repositoryService.GetListAsync<Country>();

            return View();
        }




        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    isActive = true,
                    Email = model.Email,
                    CreatedDate = DateTime.Now,
                    TwoFactorEnabled = false,
                    PhoneNumber = model.PhoneNumber,
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    ApplicationUser CurrentUser = await _applicationUserService.GetUserInfoByEmailAsync(model.Email);

                }
                AddErrors(result);
            }
            return View(model);
        }

        #endregion

        #region Login
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LogInViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                ApplicationUser userInfo = new ApplicationUser();
                if (model != null)
                {
                    userInfo = await _applicationUserService.GetUserInfoByUser(model.Name);
                    if (userInfo == null)
                    {
                        userInfo = await _applicationUserService.GetUserInfoByEmailAsync(model.Name);
                        model.Name = userInfo?.UserName;
                    }
                }


                if (userInfo != null)
                {
                    if (userInfo.isActive == true)
                    {
                        var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, lockoutOnFailure: false);
                        //return RedirectToAction("SendCode", new { ReturnUrl = returnUrl });


                        if (result.Succeeded)
                        {
                            _logger.LogInformation(1, "User logged in.");
                            var userAgent = Request.Headers["User-Agent"].ToString();
                            var mechineName = Environment.MachineName;

                            var userRole = await _applicationUserService.GetUserRoleByUserName(model.Name);


                            if (userRole == "Super Admin")
                            {
                                return RedirectToLocal(returnUrl);
                            }
                            if (userRole == "Admin")
                            {
                                return RedirectToLocal(returnUrl);
                            }
                            if (userRole == "Manager")
                            {
                                return RedirectToLocal(returnUrl);
                            }
                            if (userRole == "General User")
                            {
                                return RedirectToLocal(returnUrl);
                            }
                            else
                            {
                                return RedirectToLocal(returnUrl);
                            }

                        }
                        if (result.RequiresTwoFactor)
                        {
                            return RedirectToAction(nameof(SendCode), new { returnUrl, model.RememberMe });
                        }
                        if (result.IsLockedOut)
                        {
                            _logger.LogWarning("User account locked out.");
                            return RedirectToAction(nameof(Lockout));
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }
            return View(model);
        }







        #endregion

        #region Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            var userInfo = await _applicationUserService.GetUserInfoByUser(User.Identity.Name);
            await _signInManager.SignOutAsync();
            return Redirect("/Home/Index");

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }
        #endregion

        #region Email Confirmation
        [HttpGet]
        [AllowAnonymous]
        public IActionResult EmailSuccess()
        {
            return View();
        }

        // GET: /Account/ConfirmEmail
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }
        #endregion

        #region Forgot Password

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return View("ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=532713
                // Send an email with this link
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action(nameof(ResetPassword), "Account", new { area = "Auth", userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                return View("ForgotPasswordConfirmation");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }



        // GET: /Auth/Account/ResetPassword
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            return code == null ? View("Error") : View();
        }


        // POST: /Auth/Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(UserAccountController.ResetPasswordConfirmation), "Account", new { area = "Auth" });
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(UserAccountController.ResetPasswordConfirmation), "Account", new { area = "Auth" });
            }
            AddErrors(result);
            return View();
        }

        //
        // GET: /Auth/Account/ResetPasswordConfirmation
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
        #endregion

        #region TwoStep Verification
        // GET: /Auth/Account/SendCode
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl = null, bool rememberMe = false)
        {

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            var userFactors = await _userManager.GetValidTwoFactorProvidersAsync(user);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                return View("Error");
            }

            // Generate the token and send it
            var code = await _userManager.GenerateTwoFactorTokenAsync(user, model.SelectedProvider);
            if (string.IsNullOrWhiteSpace(code))
            {
                return View("Error");
            }

            var message = "Your security code is: " + code;
            if (model.SelectedProvider == "Email")
            {
                //await _mailService.SendTextEmailAsync(await _userManager.GetEmailAsync(user), "Security Code", message);
            }
            else if (model.SelectedProvider == "Phone")
            {
                //await _mailService.SendTextEmailAsync(await _userManager.GetPhoneNumberAsync(user), "SMS Auth", message);
            }

            return RedirectToAction(nameof(VerifyCode), new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }




        //
        // GET: /Auth/Account/VerifyCode
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> VerifyCode(string provider, bool rememberMe, string returnUrl = null)
        {
            // Require that the user has already logged in via username/password or external login
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Auth/Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes.
            // If a user enters incorrect codes for a specified amount of time then the user account
            // will be locked out for a specified amount of time.
            var result = await _signInManager.TwoFactorSignInAsync(model.Provider, model.Code, model.RememberMe, model.RememberBrowser);
            if (result.Succeeded)
            {
                return RedirectToLocal(model.ReturnUrl);
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning(7, "User account locked out.");
                return View("Lockout");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid code.");
                return View(model);
            }
        }
        #endregion

        #region ChangePassword

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePsswordViewModel model)
        {
            try
            {
                IdentityResult response;
                response= await _userManager.ChangePasswordAsync(await _userManager.FindByNameAsync(HttpContext.User.Identity.Name), model.OldPassword, model.Password);
                if (response.Succeeded)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }

            }
            catch (Exception)
            {
                return Json(false);
                throw;
            }
        }

        #endregion

        #region Check UserInfo
        [AllowAnonymous]
        [HttpGet]
        public async Task<string> RestrictDuplicateUserName(string uName)
        {
            return await _applicationUserService.CheckUserName(uName);
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<string> RestrictDuplicateEmail(string email)
        {
            return await _applicationUserService.CheckEmail(email);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<string> RestrictDuplicatePhone(string MobileNum)
        {
            return await _applicationUserService.CheckPhone(MobileNum);
        }

        #endregion

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                //return Redirect(returnUrl);
                var userId = HttpContext.User.Identity.Name;

                //return RedirectToAction(nameof(HomeController.Index), "Home", new { area = "" });
                return Redirect("~/Home/Index");
            }
            else
            {
                var userId = HttpContext.User.Identity.Name;

                //return RedirectToAction(nameof(HomeController.Index), "Home", new { area = "" });
                return Redirect("~/Home/Index");
            }
        }

        private async Task<ApplicationUser> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }

        #endregion

        #region AccessDenied
        //
        // GET:/Auth/Account/AccessDenied
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
        #endregion

    }

}
