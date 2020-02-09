using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    //1 nefer hem velosiped turu ucun,hem de hiking turu ucun beledci ola biler
    public class TypeOfGuide
    {
        public int Id { get; set; }
        [Required]
        public string GuideId { get; set; }
        public virtual ApplicationUser Guide { get; set; }
        [Required]
        public int TourTypeId { get; set; }
        public virtual TourType TourType { get; set; }
    }
}
