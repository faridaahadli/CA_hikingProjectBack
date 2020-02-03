using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class PartnerWithProduct
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public virtual PartnerCompany Partner { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int SingleTourId { get; set; }
        public virtual SingleTour SingleTour { get; set; }
        public decimal ProductCost { get; set; }
        public int SalePercent { get; set; }
        public int NumberOfProduct { get; set; }
        //bunu arawdir
        public int ProductId { get; set; }
    }
}
