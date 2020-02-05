using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Rate
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int SingleTourId { get; set; }
        public virtual SingleTour SingleTour { get; set; }
    }
}
