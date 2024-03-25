using System;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QRMenuAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace QRMenuAPI.Data
{
	public class ApplicationContext: IdentityDbContext<ApplicationUser>
	{
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<State>? States { get; set; }
        public DbSet<ApplicationUser>? ApplicationUser { get; set; }
        public DbSet<QRMenuAPI.Models.Restaurant>? Restaurant { get; set; }
        public DbSet<RestaurantUser>? RestaurantUsers { get; set; }
        public DbSet<QRMenuAPI.Models.Category>? Category { get; set; }
        public DbSet<QRMenuAPI.Models.Food>? Food { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasOne(u => u.State).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Company>().HasOne(c => c.State).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Restaurant>().HasOne(r => r.State).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<RestaurantUser>().HasKey(ru => new { ru.RestaurantId, ru.ApplicationUserId });
            modelBuilder.Entity<RestaurantUser>().HasOne(ru => ru.Restaurant).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Category>().HasOne(c => c.State).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Category>().HasOne(c => c.Restaurant).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Food>().HasOne(f => f.State).WithMany().OnDelete(DeleteBehavior.NoAction);




            base.OnModelCreating(modelBuilder);
        }
    }
}

