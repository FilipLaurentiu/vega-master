using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistance;

namespace vega.Controllers
{
    public class MakesConstroller : Controller
    {
        private readonly VegaDbContext _context;

        public MakesConstroller(VegaDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakesAsync()
        {
            return await _context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}
