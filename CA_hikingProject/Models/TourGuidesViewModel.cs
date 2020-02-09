using CA_hikingProject.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Models
{
    public class TourGuidesViewModel

    {
       

        public SingleTour Tour { get; set; }
        public ICollection<ApplicationUser> Guides { get; set; }
    }
}
