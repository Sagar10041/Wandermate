using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wandermate.Data;
using Wandermate.Interface;
using Wandermate.Models;

namespace Wandermate.Repos
{
    public class HotelReviewsRepos : HotelreviewsInterface
    {   private readonly ApplicationDbContext _context;

        public HotelReviewsRepos(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task<HotelReviews> CreateAsync(HotelReviews reviews)
        {
            await _context.HotelReviews.AddAsync(reviews );
            await _context.SaveChangesAsync();
            return reviews;
        }

        public async Task<List<HotelReviews>> GetAllAsync()
        {
            return await _context.HotelReviews.ToListAsync();
        }

        public async Task<HotelReviews?> GetByIdAsync(int id)
        {
            return await _context.HotelReviews.FindAsync(id);
        }

        

    }
}