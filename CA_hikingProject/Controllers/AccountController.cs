using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;
using CA_hikingProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CA_hikingProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<AccountController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountController(UserManager<ApplicationUser> _userManager,ILogger<AccountController> _logger,
           SignInManager<ApplicationUser> _signInManager )
        {
           this.userManager = _userManager;
           this. logger = _logger;
           this.signInManager = _signInManager;
        }

        public IActionResult Index()
        {
            return View("Login");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        //Functions for Register
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Home","Index");
            }
            var user = new ApplicationUser();
            user.Name = model.Name;
            user.UserName = model.Email;
            user.Surname = model.Surname;
            user.Email = model.Email;
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var confLink = Url.Action("ConfEmail", "Account",
                new { userId = user.Id,tok=token },Request.Scheme);
                EmailSender email = new EmailSender();
                try
                {
                    await email.SendEmailAsync(user.Email, "Confirmation Email", confLink);
                }
                catch (Exception err)
                {
                    
                }
             
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> ConfEmail(string userId,string tok)
        {
            if(userId==null || tok == null)
            {
               return RedirectToAction("Home", "Index");
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var result = await userManager.ConfirmEmailAsync(user, tok);
            if (!result.Succeeded)
            {
                return RedirectToAction("Home", "Index");
            }
            return RedirectToAction("Index"); ;
        }


        //Functions for LogIn 
     
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            //model.ReturnUrl = ReturnUrl;
            //model.ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            var user = await userManager.FindByNameAsync(model.Email);
            if (!ModelState.IsValid)
            {
                return RedirectToAction("register");
            }
            if (user == null)
                return RedirectToAction("register");
            var result = await signInManager.PasswordSignInAsync(user.Email, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                return RedirectToAction("register");
            }
            return View("LogIn", model);
        }
        #region
        //[HttpPost]
        //public async Task<IActionResult> LogIn( string returnUrl)
        //{
        //    var model = new LoginViewModel() { 
        //        ExternalLogins =(await signInManager.GetExternalAuthenticationSchemesAsync()).ToList(),
        //        ReturnUrl=returnUrl

        //    };
        //    return View();
        //}
        #endregion
        [HttpPost]
        public IActionResult ExternalLogin()
        {
            var redirectUrl = Url.Action("ExtLogCall", "Account");
            var props = signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook",props);
        }
        //[HttpPost]
        //public async Task<IActionResult> LogIn(string ReturnUrl)
        //{

        //    return View();
        //}
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }

}