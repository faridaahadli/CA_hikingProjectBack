using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class TagOfArticle
    {
        public int Id { get; set; }
        [Required]
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        [Required]
        public int BlogId { get; set; }
        public virtual Blog  Blog{ get; set; }
    }
}
