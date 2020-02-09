using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class Reply
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
