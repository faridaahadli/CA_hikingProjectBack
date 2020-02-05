using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Reply
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
