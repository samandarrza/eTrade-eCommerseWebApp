﻿using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.DAL
{
    public class EtradeDbContext: IdentityDbContext
    {
        public EtradeDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<BtmPromotion> BtmPromotions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Setting> Settings { get; set; }

        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<PhoneModel> PhoneModels { get; set; }
        public DbSet<ProcessorName> ProcessorNames { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<PhoneSystem> PhoneSystems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneImage> PhoneImages { get; set; }
        public DbSet<PhoneTag> PhoneTags { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<wishlistItem> wishlistItems { get; set; }
    }
}
