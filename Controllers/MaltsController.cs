using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using brew_logger_backend.Models;

namespace brew_logger_backend.Controllers
{
    [Route("api/brewlogger/[controller]")]
    [ApiController]
    public class MaltsController : Controller
    {
        private readonly BeerContext _context;

        public MaltsController(BeerContext context)
        {
            _context = context;
        }

        // GET: api/brewlogger/Malts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Malt>>> GetMalts() => await _context.Malts.ToListAsync();
        
        // GET: api/brewlogger/Malts/BeerName
        [HttpGet("{beerId}")]
        public async Task<ActionResult<IEnumerable<Malt>>> GetMaltsByBeer(int beerId)
        {
            // var beer = await _context.Beer.Include(beer => beer.Malts).
            //     FirstOrDefaultAsync(beer => beer.Name == beerName);
            // var malts = beer.Malts;
            var malts = await _context.Malts.Include(malts => malts.Beer)
                .Where(malt => malt.Beer.Id == beerId).ToListAsync();
            //var malts = _context.Malts.Where(malt =>  )

            //var malts = await _context.Malts.Include(malts => malts.Beer)
            //    .Where(malt => malt.Beer.Name == beerName).ToListAsync();

            if (malts.Count == 0)
            {
                return NotFound();
            }

            return malts;
        }
        
        

    }
}