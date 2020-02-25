using CA_hikingProject.DbModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Models
{
    public class TourViewModel
    {
        public SingleTour Tour { get; set; }
        public List<AllImage> Photos { get; set; }
    }
}
