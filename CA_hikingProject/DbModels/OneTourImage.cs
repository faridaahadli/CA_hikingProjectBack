using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class OneTourImage
    {
        public int Id { get; set; }
        [Required]
        public int SingleTourId { get; set; }
        public virtual SingleTour SingleTour { get; set; }
        [Required]
        public int AllImageId { get; set; }
        public virtual AllImage myImage { get; set; }
        public bool IsIntro { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}
