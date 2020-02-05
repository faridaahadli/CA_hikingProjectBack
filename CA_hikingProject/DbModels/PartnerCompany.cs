using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class PartnerCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Contact { get; set; }
        public string API_Key { get; set; }

        public virtual ICollection<PartnerWithProduct> Products { get; set; }
    }
}
