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
    public class AlternatePartController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public AlternatePartController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/AlternatePart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlternatePart>>> GetAlternateParts()
        {
            return await _context.AlternatePart.ToListAsync();
        }

        // GET: api/AlternateParts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlternatePart>> GetAlternatePart(decimal id)
        {
            var alternatePart = await _context.AlternatePart.FindAsync(id);

            if (alternatePart == null)
            {
                return NotFound();
            }

            return alternatePart;
        }

        // PUT: api/AlternateParts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlternatePart(decimal id, AlternatePart alternatePart)
        {
            if (id != alternatePart.Counter)
            {
                return BadRequest();
            }

            _context.Entry(alternatePart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlternatePartExists(id))
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

        // POST: api/AlternateParts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AlternatePart>> PostAlternatePart(AlternatePart alternatePart)
        {
            _context.AlternatePart.Add(alternatePart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlternatePart", new { id = alternatePart.Counter }, alternatePart);
        }

        // DELETE: api/AlternateParts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AlternatePart>> DeleteAlternatePart(decimal id)
        {
            var alternatePart = await _context.AlternatePart.FindAsync(id);
            if (alternatePart == null)
            {
                return NotFound();
            }

            _context.AlternatePart.Remove(alternatePart);
            await _context.SaveChangesAsync();

            return alternatePart;
        }

        private bool AlternatePartExists(decimal id)
        {
            return _context.AlternatePart.Any(e => e.Counter == id);
        }
    }
}
