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
    public class POLineController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public POLineController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/POLine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Poline>>> GetPOLine()
        {
            return await _context.POLine.ToListAsync();
        }

        // GET: api/Polines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Poline>> GetPOLine(int id)
        {
            var poline = await _context.POLine.FindAsync(id);

            if (poline == null)
            {
                return NotFound();
            }

            return poline;
        }

        // PUT: api/Polines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PuPOLine(int id, Poline poline)
        {
            if (id != poline.Counter)
            {
                return BadRequest();
            }

            _context.Entry(poline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POLineExists(id))
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

        // POST: api/Polines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Poline>> PostPOLine(Poline poline)
        {
            _context.POLine.Add(poline);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPoline", new { id = poline.Counter }, poline);
        }

        // DELETE: api/Polines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Poline>> DeletePOLine(int id)
        {
            var poline = await _context.POLine.FindAsync(id);
            if (poline == null)
            {
                return NotFound();
            }

            _context.POLine.Remove(poline);
            await _context.SaveChangesAsync();

            return poline;
        }

        private bool POLineExists(int id)
        {
            return _context.POLine.Any(e => e.Counter == id);
        }
    }
}
