using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="This file is required")]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
