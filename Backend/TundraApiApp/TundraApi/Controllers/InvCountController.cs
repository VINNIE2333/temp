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
    public class InvCountController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InvCountController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InvCount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvCount>>> GetInvCount()
        {
            return await _context.InvCount.ToListAsync();
        }

        // GET: api/InvCount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvCount>> GetInvCount(string id)
        {
            var invCount = await _context.InvCount.FindAsync(id);

            if (invCount == null)
            {
                return NotFound();
            }

            return invCount;
        }

        // PUT: api/InvCounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvCount(string id, InvCount invCount)
        {
            if (id != invCount.BatchNum)
            {
                return BadRequest();
            }

            _context.Entry(invCount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvCountExists(id))
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

        // POST: api/InvCounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvCount>> PostInvCount(InvCount invCount)
        {
            _context.InvCount.Add(invCount);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InvCountExists(invCount.BatchNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInvCount", new { id = invCount.BatchNum }, invCount);
        }

        // DELETE: api/InvCounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvCount>> DeleteInvCount(string id)
        {
            var invCount = await _context.InvCount.FindAsync(id);
            if (invCount == null)
            {
                return NotFound();
            }

            _context.InvCount.Remove(invCount);
            await _context.SaveChangesAsync();

            return invCount;
        }

        private bool InvCountExists(string id)
        {
            return _context.InvCount.Any(e => e.BatchNum == id);
        }
    }
}
