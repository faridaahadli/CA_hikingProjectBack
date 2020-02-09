using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Rate
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [Required]
        public int SingleTourId { get; set; }
        public virtual SingleTour SingleTour { get; set; }
    }
}
