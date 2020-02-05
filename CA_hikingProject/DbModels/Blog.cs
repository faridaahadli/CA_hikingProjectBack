using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Blog
    {
       
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string WriterId { get; set; }
        public virtual ApplicationUser Writer { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime SharedDate { get; set; } = DateTime.Now;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<TagOfArticle> TagsOfArticle { get; set; }

    }
}
