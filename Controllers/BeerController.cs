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
    public class BeerController : ControllerBase
    {
        private readonly BeerContext _context;

        public BeerController(BeerContext context)
        {
            _context = context;
        }
        
        

        // GET: api/brewlogger/Beer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beer>>> GetBeer()
        {
            return await _context.Beer.ToListAsync();
        }

        // GET: api/Beer/5
        [HttpGet("{name}")]
        public async Task<ActionResult<Beer>> GetBeer(string name)
        {
            // var id = _context.Beer.FirstOrDefault()
            var beer = await _context.Beer.FirstOrDefaultAsync(beer => beer.Name == name );

            if (beer == null)
            {
                return NotFound();
            }

            return beer;
        }

        // PUT: api/Beer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{name}")]
        public async Task<IActionResult> PutBeer(string name, Beer beer)
        {
            if (name != beer.Name)
            {
                return BadRequest();
            }

            _context.Entry(beer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeerExists(name))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Beer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Beer>> PostBeer(Beer beer)
        {
            _context.Beer.Add(beer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeer", new { name = beer.Name }, beer);
        }

        // DELETE: api/Beer/5
        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteBeer(string name)
        {
            var beer = await _context.Beer.FirstOrDefaultAsync(beer => beer.Name == name );
            if (beer == null)
            {
                return NotFound();
            }

            _context.Beer.Remove(beer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BeerExists(string name)
        {
            return _context.Beer.Any(e => e.Name == name);
        }
    }
}
