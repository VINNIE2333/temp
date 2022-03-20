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
    public class LocHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public LocHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/LocHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocHistory>>> GetLocHistory()
        {
            return await _context.LocHistory.ToListAsync();
        }

        // GET: api/LocHistory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocHistory>> GetLocHistory(int id)
        {
            var locHistory = await _context.LocHistory.FindAsync(id);

            if (locHistory == null)
            {
                return NotFound();
            }

            return locHistory;
        }

        // PUT: api/LocHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocHistory(int id, LocHistory locHistory)
        {
            if (id != locHistory.Counter)
            {
                return BadRequest();
            }

            _context.Entry(locHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocHistoryExists(id))
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

        // POST: api/LocHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LocHistory>> PostLocHistory(LocHistory locHistory)
        {
            _context.LocHistory.Add(locHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocHistory", new { id = locHistory.Counter }, locHistory);
        }

        // DELETE: api/LocHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocHistory>> DeleteLocHistory(int id)
        {
            var locHistory = await _context.LocHistory.FindAsync(id);
            if (locHistory == null)
            {
                return NotFound();
            }

            _context.LocHistory.Remove(locHistory);
            await _context.SaveChangesAsync();

            return locHistory;
        }

        private bool LocHistoryExists(int id)
        {
            return _context.LocHistory.Any(e => e.Counter == id);
        }
    }
}
