using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess
{
    public class WebsuperContext : IdentityDbContext<WebsuperUser>
    {
        public WebsuperContext(DbContextOptions<WebsuperContext> options) : base(options)
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Additionaly> Additionalies { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ConsultNow> ConsultNows { get; set; }
        public DbSet<CountDown> CountDowns { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OneBlog> OneBlogs { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SubAdditionaly> SubAdditionalies { get; set; }
        public DbSet<WebsuperUser> WebsuperUsers { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This needs to go before the other rules!

            modelBuilder.Entity<WebsuperUser>().ToTable("Users");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}