using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Requirement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SingleTourId { get; set; }
        public virtual SingleTour SingleTour { get; set; }
    }
}
