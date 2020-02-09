using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string GuideId { get; set; }
        public virtual ApplicationUser TagCreator { get; set; }
    }
}
