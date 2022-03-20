using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TDBMS.Models;
using TDBMS.Models.TableModels;

namespace TDBMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WOMaterialController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WOMaterialController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Womaterials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Womaterial>>> GetWOMaterial()
        {
            return await _context.WOMaterial.ToListAsync();
        }

        // GET: api/Womaterials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Womaterial>> GetWomaterial(int id)
        {
            var womaterial = await _context.WOMaterial.FindAsync(id);

            if (womaterial == null)
            {
                return NotFound();
            }

            return womaterial;
        }

        // PUT: api/Womaterials/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWOMaterial(int id, Womaterial womaterial)
        {
            if (id != womaterial.Counter)
            {
                return BadRequest();
            }

            _context.Entry(womaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WOMaterialExists(id))
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

        // POST: api/Womaterials
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Womaterial>> PostWOMaterial(Womaterial womaterial)
        {
            _context.WOMaterial.Add(womaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWomaterial", new { id = womaterial.Counter }, womaterial);
        }

        // DELETE: api/Womaterials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Womaterial>> DeleteWomaterial(int id)
        {
            var womaterial = await _context.WOMaterial.FindAsync(id);
            if (womaterial == null)
            {
                return NotFound();
            }

            _context.WOMaterial.Remove(womaterial);
            await _context.SaveChangesAsync();

            return womaterial;
        }

        private bool WOMaterialExists(int id)
        {
            return _context.WOMaterial.Any(e => e.Counter == id);
        }
    }
}
