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
    public class DestinationReviewsRepos : DestinationReviewsInterface
    {
         private readonly ApplicationDbContext _context;

        public DestinationReviewsRepos(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task<DestinationReviews> CreateAsync(DestinationReviews reviews)
        {
            await _context.DestinationReviews.AddAsync(reviews );
            await _context.SaveChangesAsync();
            return reviews;
        }

        public async Task<DestinationReviews?> DeleteAsync(int id)
        {
          var rev = await _context.DestinationReviews.FirstOrDefaultAsync(x => x.ReviewId == id);

            if ( rev == null){
                return null;
            }
            _context.DestinationReviews.Remove(rev);
           await _context.SaveChangesAsync();
           return rev;
        }

        public async Task<List<DestinationReviews>> GetAllAsync()
        {
            return await _context.DestinationReviews.Include(x=>x.AppUser).ToListAsync();
        }

        public async Task<DestinationReviews?> GetByIdAsync(int id)
        {
            return await _context.DestinationReviews.Include(x=>x.AppUser).FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<DestinationReviews?> UpdateAsync(int id, DestinationReviews reviews)
        {
            var oldreview = await _context.DestinationReviews.FindAsync(id);
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