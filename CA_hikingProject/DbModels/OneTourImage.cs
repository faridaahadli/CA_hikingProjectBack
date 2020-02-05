using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class OneTourImage
    {
        public int Id { get; set; }
        public int SingleTourId { get; set; }
        public virtual SingleTour SingleTour { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public bool IsIntro { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
