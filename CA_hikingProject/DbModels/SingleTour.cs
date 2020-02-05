using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class SingleTour
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int MaxPersonLimit { get; set; }
        public bool IsActive { get; set; } = true;
        [Required]
        public string MeetAddress { get; set; }
        public int SalePercent { get; set; }
        public string LocationStory { get; set; }
        public string Warning { get; set; }
      
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
