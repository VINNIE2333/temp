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
    public class PhaseController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public PhaseController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Phase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Phase>>> GetPhase()
        {
            return await _context.Phase.ToListAsync();
        }

        // GET: api/Phases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Phase>> GetPhase(int id)
        {
            var phase = await _context.Phase.FindAsync(id);

            if (phase == null)
            {
                return NotFound();
            }

            return phase;
        }

        // PUT: api/Phases/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhase(int id, Phase phase)
        {
            if (id != phase.Counter)
            {
                return BadRequest();
            }

            _context.Entry(phase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhaseExists(id))
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

        // POST: api/Phases
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Phase>> PostPhase(Phase phase)
        {
            _context.Phase.Add(phase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhase", new { id = phase.Counter }, phase);
        }

        // DELETE: api/Phases/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Phase>> DeletePhase(int id)
        {
            var phase = await _context.Phase.FindAsync(id);
            if (phase == null)
            {
                return NotFound();
            }

            _context.Phase.Remove(phase);
            await _context.SaveChangesAsync();

            return phase;
        }

        private bool PhaseExists(int id)
        {
            return _context.Phase.Any(e => e.Counter == id);
        }
    }
}
