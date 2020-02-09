using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class GuideToTourPvt
    {
        public int Id { get; set; }
        [Required]
        public string GuideId { get; set; }
        public virtual ApplicationUser Guide { get; set; }
        [Required]
        public int TourId { get; set; }
        public virtual SingleTour Tour { get; set; }
    }
}
