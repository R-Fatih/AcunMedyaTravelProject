﻿using AcunMedyaTravelProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaTravelProject.Context
{
    public class AppDbContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;initial catalog=TravelDb;integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Tour> Tours { get; set; }
    }
}
