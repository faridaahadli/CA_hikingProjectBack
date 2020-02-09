using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class TourType
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zehmet olmasa turun novunu daxil edin")]
        public string Name { get; set; }
        public bool StillActive { get; set; } = true;
        public virtual ICollection<SingleTour> Tours{ get; set; }
        public virtual ICollection<TypeOfGuide> TypeOfGuides { get; set; }
    }
}
