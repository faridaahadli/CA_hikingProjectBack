using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Image
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public virtual ICollection<OneTourImage> TourImages { get; set; }
        
    }
}
