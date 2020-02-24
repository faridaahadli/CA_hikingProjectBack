using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;
using CA_hikingProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CA_hikingProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminpanelController : Controller
    {
        
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AdminpanelController(UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager,
            SignInManager<ApplicationUser> _signInManager)
        {
          this.userManager = _userManager;
          this.roleManager = _roleManager;
            this.signInManager = _signInManager;
        }
      [HttpGet]
    public IActionResult Index()
        {
         
            return View("Login");
        }
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
            return RedirectToAction("Index","SingleTours");
        }


        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Adminpanel");
        }
    }
}