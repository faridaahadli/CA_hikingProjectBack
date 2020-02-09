using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CA_hikingProject.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;


    public AdminController(UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
          this.userManager = _userManager;
          this.roleManager = _roleManager;
        }
      
    public IActionResult Index()
        {
         
            return View();
        }
    }
}