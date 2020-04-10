using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Models
{
    public class LoginViewModel
    { 
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;
        public string ReturnUrl { get; set; }
        //public IList<AuthenticationScheme> ExternalLogins{ get; set; }
    }
}
