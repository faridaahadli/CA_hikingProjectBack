using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class SingleTour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int MaxPersonLimit { get; set; }
        public bool IsActive { get; set; } = true;
        public string MeetAddress { get; set; }
        public int SalePercent { get; set; }
        public string LocationStory { get; set; }

        public int TourTypeId { get; set; }
        public virtual TourType TourType { get; set; }
        public virtual ICollection<UserCustomPayingInfo> UserCustomPayings { get; set; }
        public virtual ICollection<GuideToTourPvt> GuidesToTours { get; set; }
        public virtual ICollection<Requirement> Requirements { get; set; }
        public virtual ICollection<OneTourImage> TourImages { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<PartnerWithProduct> Products { get; set; }
    }

}
