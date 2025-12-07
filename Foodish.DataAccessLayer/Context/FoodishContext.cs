using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foodish.DataAccessLayer.Context
{
    public class FoodishContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-UGIL0VOD\\SQLEXPRESS01;initial catalog=FoodishDb;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Article> Articles { get; set; }

    }
}
