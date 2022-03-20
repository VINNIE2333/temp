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
    public class EQHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public EQHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Eqhistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eqhistory>>> GetEQHistory()
        {
            return await _context.EQHistory.ToListAsync();
        }

        // GET: api/Eqhistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eqhistory>> GetEQHistory(int id)
        {
            var eqhistory = await _context.EQHistory.FindAsync(id);

            if (eqhistory == null)
            {
                return NotFound();
            }

            return eqhistory;
        }

        // PUT: api/Eqhistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEqhistory(int id, Eqhistory eqhistory)
        {
            if (id != eqhistory.Counter)
            {
                return BadRequest();
            }

            _context.Entry(eqhistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EqhistoryExists(id))
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

        // POST: api/Eqhistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eqhistory>> PostEqhistory(Eqhistory eqhistory)
        {
            _context.EQHistory.Add(eqhistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEqhistory", new { id = eqhistory.Counter }, eqhistory);
        }

        // DELETE: api/Eqhistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eqhistory>> DeleteEqhistory(int id)
        {
            var eqhistory = await _context.EQHistory.FindAsync(id);
            if (eqhistory == null)
            {
                return NotFound();
            }

            _context.EQHistory.Remove(eqhistory);
            await _context.SaveChangesAsync();

            return eqhistory;
        }

        private bool EqhistoryExists(int id)
        {
            return _context.EQHistory.Any(e => e.Counter == id);
        }
    }
}
