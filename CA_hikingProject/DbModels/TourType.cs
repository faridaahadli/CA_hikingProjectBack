using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class TourType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SingleTour> Tours{ get; set; }
        public virtual ICollection<TypeOfGuide> TypeOfGuides { get; set; }
    }
}
