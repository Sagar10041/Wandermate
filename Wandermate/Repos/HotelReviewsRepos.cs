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
        public async Task<List<HotelReviews>> GetAllAsync()
        {
            return await _context.HotelReviews.ToListAsync();
        }
    }
}