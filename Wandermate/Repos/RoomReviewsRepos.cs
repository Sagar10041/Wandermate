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
    public class RoomReviewsRepos : RoomReviewsInterface
    {
         private readonly ApplicationDbContext _context;

        public RoomReviewsRepos(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task<RoomReviews> CreateAsync(RoomReviews reviews)
        {
            await _context.RoomReviews.AddAsync(reviews );
            await _context.SaveChangesAsync();
            return reviews;
        }

        public async Task<RoomReviews?> DeleteAsync(int id)
        {
          var rev = await _context.RoomReviews.FirstOrDefaultAsync(x => x.ReviewId == id);

            if ( rev == null){
                return null;
            }
            _context.RoomReviews.Remove(rev);
           await _context.SaveChangesAsync();
           return rev;
        }

        public async Task<List<RoomReviews>> GetAllAsync()
        {
            return await _context.RoomReviews.ToListAsync();
        }

        public async Task<RoomReviews?> GetByIdAsync(int id)
        {
            return await _context.RoomReviews.FindAsync(id);
        }

        public async Task<RoomReviews?> UpdateAsync(int id, RoomReviews reviews)
        {
            var oldreview = await _context.RoomReviews.FindAsync(id);
            if (oldreview == null){
                return null;
            }
            oldreview.Rating = reviews.Rating;
            oldreview.ReviewText=reviews.ReviewText;

            await _context.SaveChangesAsync();
            return oldreview;

        }

    }
}