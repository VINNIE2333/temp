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
    public class InvLotController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InvLotController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InvLot
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvLot>>> GetInvLot()
        {
            return await _context.InvLot.ToListAsync();
        }

        // GET: api/InvLot/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvLot>> GetInvLot(decimal id)
        {
            var invLot = await _context.InvLot.FindAsync(id);

            if (invLot == null)
            {
                return NotFound();
            }

            return invLot;
        }

        // PUT: api/InvLots/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvLot(decimal id, InvLot invLot)
        {
            if (id != invLot.Counter)
            {
                return BadRequest();
            }

            _context.Entry(invLot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvLotExists(id))
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

        // POST: api/InvLots
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvLot>> PostInvLot(InvLot invLot)
        {
            _context.InvLot.Add(invLot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvLot", new { id = invLot.Counter }, invLot);
        }

        // DELETE: api/InvLots/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvLot>> DeleteInvLot(decimal id)
        {
            var invLot = await _context.InvLot.FindAsync(id);
            if (invLot == null)
            {
                return NotFound();
            }

            _context.InvLot.Remove(invLot);
            await _context.SaveChangesAsync();

            return invLot;
        }

        private bool InvLotExists(decimal id)
        {
            return _context.InvLot.Any(e => e.Counter == id);
        }
    }
}
