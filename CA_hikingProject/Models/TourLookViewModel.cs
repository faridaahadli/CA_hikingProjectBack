using CA_hikingProject.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Models
{
    public class TourLookViewModel
    {
        public SingleTour Tour { get; set; }
        public List<AllImage> Images { get; set; }
        public List<ApplicationUser> Guides { get; set; }
    }
}
