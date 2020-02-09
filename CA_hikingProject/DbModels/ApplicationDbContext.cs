using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;


namespace CA_hikingProject.DbModels
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options){}
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<GuideDetails> GuideDetails { get; set; }
        public DbSet<GuideToTourPvt> GuideToTourPvts { get; set; }
        public DbSet<AllImage> Images { get; set; }
        public DbSet<NavMenu> NavMenus { get; set; }
        public DbSet<OneTourImage> OneTourImages { get; set; }
        public DbSet<PartnerCompany>  PartnerCompanies { get; set; }
        public DbSet<PartnerWithProduct> PartnerWithProducts { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Requirement> Requirements{ get; set; }
        public DbSet<SingleTour> SingleTours { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagOfArticle> TagsOfArticles { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<TypeOfGuide> TypeOfGuides{ get; set; }
        public DbSet<UserCustomPayingInfo> UserCustomPayingInfos { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }

    }
}
