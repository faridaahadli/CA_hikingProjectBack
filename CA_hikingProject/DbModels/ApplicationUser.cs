using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.DbModels
{
    public class ApplicationUser:IdentityUser
    {
        public string Role { get; set; }  // bunu arawdir
        public bool IsBlocked { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<Blog> Blogs{ get; set; }
        public virtual ICollection<UserCustomPayingInfo> UserCustomPayings { get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public virtual ICollection<TypeOfGuide> TypeOfGuides { get; set; }
        public virtual ICollection<Tag> CreatedTags { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<PartnerWithProduct> Products { get; set; }
    }
}
