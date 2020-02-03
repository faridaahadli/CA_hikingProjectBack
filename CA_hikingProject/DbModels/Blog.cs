using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Blog
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int WriterId { get; set; }
        public virtual ApplicationUser Writer { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime SharedDate { get; set; } = DateTime.Now;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<TagOfArticle> TagsOfArticle { get; set; }

    }
}
