using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class UserCustomPayingInfo
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int TourId { get; set; }
        public virtual SingleTour Tour { get; set; }
        public int PersonNumber { get; set; }
        public bool IsReturned { get; set; } = false;
        public string Contact { get; set; }
    }
}
