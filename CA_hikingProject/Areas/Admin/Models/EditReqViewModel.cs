using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Areas.Admin.Models
{
    public class EditReqViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Selected { get; set; } = false;
    }
}
