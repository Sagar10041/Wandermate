using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Models;

namespace Wandermate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) 
        : base (dbContextOptions)
        {

            
        }

        public DbSet <Hotels> Hotels {get; set;}
        public DbSet <HotelReviews> HotelReviews {get; set;}
    }
}