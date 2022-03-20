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
    public class WOHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WOHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Wohistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wohistory>>> GetWOHistory()
        {
            return await _context.WOHistory.ToListAsync();
        }

        // GET: api/Wohistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wohistory>> GetWohistory(decimal id)
        {
            var wohistory = await _context.WOHistory.FindAsync(id);

            if (wohistory == null)
            {
                return NotFound();
            }

            return wohistory;
        }

        // PUT: api/Wohistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWohistory(decimal id, Wohistory wohistory)
        {
            if (id != wohistory.Counter)
            {
                return BadRequest();
            }

            _context.Entry(wohistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WohistoryExists(id))
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

        // POST: api/Wohistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Wohistory>> PostWohistory(Wohistory wohistory)
        {
            _context.WOHistory.Add(wohistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWohistory", new { id = wohistory.Counter }, wohistory);
        }

        // DELETE: api/Wohistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wohistory>> DeleteWohistory(decimal id)
        {
            var wohistory = await _context.WOHistory.FindAsync(id);
            if (wohistory == null)
            {
                return NotFound();
            }

            _context.WOHistory.Remove(wohistory);
            await _context.SaveChangesAsync();

            return wohistory;
        }

        private bool WohistoryExists(decimal id)
        {
            return _context.WOHistory.Any(e => e.Counter == id);
        }
    }
}
