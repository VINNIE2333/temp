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
    public class NestedProcController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public NestedProcController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/NestedProc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NestedProc>>> GetNestedProc()
        {
            return await _context.NestedProc.ToListAsync();
        }

        // GET: api/NestedProcs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NestedProc>> GetNestedProc(int id)
        {
            var nestedProc = await _context.NestedProc.FindAsync(id);

            if (nestedProc == null)
            {
                return NotFound();
            }

            return nestedProc;
        }

        // PUT: api/NestedProcs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNestedProc(int id, NestedProc nestedProc)
        {
            if (id != nestedProc.Counter)
            {
                return BadRequest();
            }

            _context.Entry(nestedProc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NestedProcExists(id))
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

        // POST: api/NestedProcs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NestedProc>> PostNestedProc(NestedProc nestedProc)
        {
            _context.NestedProc.Add(nestedProc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNestedProc", new { id = nestedProc.Counter }, nestedProc);
        }

        // DELETE: api/NestedProcs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NestedProc>> DeleteNestedProc(int id)
        {
            var nestedProc = await _context.NestedProc.FindAsync(id);
            if (nestedProc == null)
            {
                return NotFound();
            }

            _context.NestedProc.Remove(nestedProc);
            await _context.SaveChangesAsync();

            return nestedProc;
        }

        private bool NestedProcExists(int id)
        {
            return _context.NestedProc.Any(e => e.Counter == id);
        }
    }
}
