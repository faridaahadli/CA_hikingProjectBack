using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class GuideDetails
    {
        public int Id { get; set; }
        public string GuideId { get; set; }
        public virtual ApplicationUser  Guide { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public string Description { get; set; }
    }
}
