using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wandermate.Models;

namespace Wandermate.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) 
        : base (dbContextOptions)
        {

            
        }

        public DbSet <Hotels> Hotels {get; set;}
        public DbSet <HotelReviews> HotelReviews {get; set;}
        public DbSet <Destination> Destination {get; set;}
        public DbSet <DestinationReviews> DestinationReviews {get; set;}

        public DbSet <Rooms> Rooms {get; set;}
        public DbSet <RoomReviews> RoomReviews {get; set;}
        public DbSet <DestinationBooking> DestinationBookings {get; set;}

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            
            builder.Entity<DestinationBooking>(x => x.HasKey(p => new { p.AppUserId, p.DestinationId }));

            builder.Entity<DestinationBooking>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.DestinationBookings)
                .HasForeignKey(p => p.AppUserId);

            builder.Entity<DestinationBooking>()
                .HasOne(u => u.Destination)
                .WithMany(u => u.DestinationBookings)
                .HasForeignKey(p => p.DestinationId);

            List<IdentityRole> roles = new List<IdentityRole>{
                new IdentityRole{
                    Name ="Admin",
                    NormalizedName="ADMIN"
                },
                new IdentityRole{
                    Name ="User",
                    NormalizedName="USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}