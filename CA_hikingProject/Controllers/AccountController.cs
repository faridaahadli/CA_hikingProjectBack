using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;
using CA_hikingProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CA_hikingProject.Controllers
{
    [AllowAnonymous]
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
        [HttpGet]
        public IActionResult Index(string returnUrl)
        {
            var model = new LoginViewModel()
            {
               ReturnUrl=returnUrl
            };

            
            return View("Login",model);
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
        public IActionResult ExternalLogin(string provider,string returnUrl)
        {
            var redUrl = Url.Action("CallBack", "Account", new { ReturnUrl = returnUrl });
            var props = signInManager.ConfigureExternalAuthenticationProperties(provider, redUrl);
            return new ChallengeResult(provider, props);
        }

        public async Task<IActionResult> CallBack(string returnUrl=null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            var model = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };
            var info = await  signInManager.GetExternalLoginInfoAsync();
            if (info==null)
            {
                return RedirectToAction("Index",model);
            }
            var res = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,info.ProviderKey,
                isPersistent:false,bypassTwoFactor:true);
            if (res.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            if (email != null)
            {
                var user = await userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    user = new ApplicationUser()
                    {
                        UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };
                    await userManager.CreateAsync(user);
                }
                await userManager.AddLoginAsync(user, info);
                await signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect(returnUrl);
            }
           
                return View("Error");   
           }
        
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }

}