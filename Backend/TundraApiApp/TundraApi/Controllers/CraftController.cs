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
    public class CraftController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public CraftController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Craft
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Craft>>> GetCraft()
        {
            return await _context.Craft.ToListAsync();
        }

        // GET: api/Crafts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Craft>> GetCraft(string id)
        {
            var craft = await _context.Craft.FindAsync(id);

            if (craft == null)
            {
                return NotFound();
            }

            return craft;
        }

        // PUT: api/Crafts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraft(string id, Craft craft)
        {
            if (id != craft.Craft1)
            {
                return BadRequest();
            }

            _context.Entry(craft).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraftExists(id))
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

        // POST: api/Crafts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Craft>> PostCraft(Craft craft)
        {
            _context.Craft.Add(craft);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraftExists(craft.Craft1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraft", new { id = craft.Craft1 }, craft);
        }

        // DELETE: api/Crafts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Craft>> DeleteCraft(string id)
        {
            var craft = await _context.Craft.FindAsync(id);
            if (craft == null)
            {
                return NotFound();
            }

            _context.Craft.Remove(craft);
            await _context.SaveChangesAsync();

            return craft;
        }

        private bool CraftExists(string id)
        {
            return _context.Craft.Any(e => e.Craft1 == id);
        }
    }
}
