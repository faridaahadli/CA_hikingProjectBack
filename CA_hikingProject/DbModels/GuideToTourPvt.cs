using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class GuideToTourPvt
    {
        public int Id { get; set; }
        public string GuideId { get; set; }
        public virtual ApplicationUser Guide { get; set; }
        public int TourId { get; set; }
        public virtual SingleTour Tour { get; set; }
    }
}
