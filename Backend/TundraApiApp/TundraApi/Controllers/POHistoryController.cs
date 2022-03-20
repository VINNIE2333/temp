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
    public class POHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public POHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/POHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pohistory>>> GetPOHistory()
        {
            return await _context.POHistory.ToListAsync();
        }

        // GET: api/Pohistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pohistory>> GetPOHistory(int id)
        {
            var pohistory = await _context.POHistory.FindAsync(id);

            if (pohistory == null)
            {
                return NotFound();
            }

            return pohistory;
        }

        // PUT: api/Pohistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPOHistory(int id, Pohistory pohistory)
        {
            if (id != pohistory.Counter)
            {
                return BadRequest();
            }

            _context.Entry(pohistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POHistoryExists(id))
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

        // POST: api/Pohistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pohistory>> PostPOHistory(Pohistory pohistory)
        {
            _context.POHistory.Add(pohistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPohistory", new { id = pohistory.Counter }, pohistory);
        }

        // DELETE: api/Pohistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pohistory>> DeletePOHistory(int id)
        {
            var pohistory = await _context.POHistory.FindAsync(id);
            if (pohistory == null)
            {
                return NotFound();
            }

            _context.POHistory.Remove(pohistory);
            await _context.SaveChangesAsync();

            return pohistory;
        }

        private bool POHistoryExists(int id)
        {
            return _context.POHistory.Any(e => e.Counter == id);
        }
    }
}
