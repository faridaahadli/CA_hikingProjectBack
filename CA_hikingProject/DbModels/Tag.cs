using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GuideId { get; set; }
        public virtual ApplicationUser TagCreator { get; set; }
    }
}
