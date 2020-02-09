using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class AllImage
    {
        public int Id { get; set; }
        [Required]
        public string Source { get; set; }
        public virtual ICollection<OneTourImage> TourImages { get; set; }
        
    }
}
