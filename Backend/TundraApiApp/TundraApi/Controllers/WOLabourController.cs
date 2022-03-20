using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TundraApi.Data;
using TundraApi.Models;

namespace TundraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WolaboursController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WolaboursController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/WOLabour
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wolabour>>> GetWOLabour()
        {
            return await _context.WOLabour.ToListAsync();
        }

        // GET: api/Wolabours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wolabour>> GetWOLabour(decimal id)
        {
            var wolabour = await _context.WOLabour.FindAsync(id);

            if (wolabour == null)
            {
                return NotFound();
            }

            return wolabour;
        }

        // PUT: api/Wolabours/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWOLabour(decimal id, Wolabour wolabour)
        {
            if (id != wolabour.Counter)
            {
                return BadRequest();
            }

            _context.Entry(wolabour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WOLabourExists(id))
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

        // POST: api/Wolabours
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Wolabour>> PostWOLabour(Wolabour wolabour)
        {
            _context.WOLabour.Add(wolabour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWolabour", new { id = wolabour.Counter }, wolabour);
        }

        // DELETE: api/Wolabours/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wolabour>> DeleteWOLabour(decimal id)
        {
            var wolabour = await _context.WOLabour.FindAsync(id);
            if (wolabour == null)
            {
                return NotFound();
            }

            _context.WOLabour.Remove(wolabour);
            await _context.SaveChangesAsync();

            return wolabour;
        }

        private bool WOLabourExists(decimal id)
        {
            return _context.WOLabour.Any(e => e.Counter == id);
        }
    }
}
