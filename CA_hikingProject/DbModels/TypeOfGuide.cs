using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    //1 nefer hem velosiped turu ucun,hem de hiking turu ucun beledci ola biler
    public class TypeOfGuide
    {
        public int Id { get; set; }
        public string GuideId { get; set; }
        public virtual ApplicationUser Guide { get; set; }
        public int TourTypeId { get; set; }
        public virtual TourType TourType { get; set; }
    }
}
