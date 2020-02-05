using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public DateTime SharedDate { get; set; } = DateTime.Now;
    }
}
