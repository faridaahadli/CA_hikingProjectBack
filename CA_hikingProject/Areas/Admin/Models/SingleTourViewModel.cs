using CA_hikingProject.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Areas.Admin.Models
{
    public class SingleTourViewModel
    {
        public SingleTour singleTour{ get; set; }
        [Required(ErrorMessage ="Beledciler elave olunmasi mecburidir")]
        public ICollection<string> Guides { get; set; }
        [Required]
        public string Requirement { get; set; }

    }
}
