using CA_hikingProject.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Areas.Admin.Models
{
    public class TourViewModel
    {
        public SingleTour Tour { get; set; }
        public List<EditReqViewModel> Requirements { get; set; }
        public List<EditImgViewModel> Photos { get; set; }
    }
}
