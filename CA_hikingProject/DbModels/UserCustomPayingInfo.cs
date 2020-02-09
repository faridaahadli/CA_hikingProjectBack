using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class UserCustomPayingInfo
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [Required]
        public int TourId { get; set; }
        public virtual SingleTour Tour { get; set; }
        [Required]
        public int PersonNumber { get; set; }
        public bool IsReturned { get; set; } = false;
        [Required]
        public string Contact { get; set; }
    }
}
