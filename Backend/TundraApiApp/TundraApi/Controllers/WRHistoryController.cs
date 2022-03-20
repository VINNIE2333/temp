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
    public class WRHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WRHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Wrhistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wrhistory>>> GetWRHistory()
        {
            return await _context.WRHistory.ToListAsync();
        }

        // GET: api/Wrhistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wrhistory>> GetWRHistory(decimal id)
        {
            var wrhistory = await _context.WRHistory.FindAsync(id);

            if (wrhistory == null)
            {
                return NotFound();
            }

            return wrhistory;
        }

        // PUT: api/Wrhistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWRHistory(decimal id, Wrhistory wrhistory)
        {
            if (id != wrhistory.Counter)
            {
                return BadRequest();
            }

            _context.Entry(wrhistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WRHistoryExists(id))
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

        // POST: api/Wrhistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Wrhistory>> PostWRHistory(Wrhistory wrhistory)
        {
            _context.WRHistory.Add(wrhistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWrhistory", new { id = wrhistory.Counter }, wrhistory);
        }

        // DELETE: api/Wrhistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wrhistory>> DeleteWRHistory(decimal id)
        {
            var wrhistory = await _context.WRHistory.FindAsync(id);
            if (wrhistory == null)
            {
                return NotFound();
            }

            _context.WRHistory.Remove(wrhistory);
            await _context.SaveChangesAsync();

            return wrhistory;
        }

        private bool WRHistoryExists(decimal id)
        {
            return _context.WRHistory.Any(e => e.Counter == id);
        }
    }
}
