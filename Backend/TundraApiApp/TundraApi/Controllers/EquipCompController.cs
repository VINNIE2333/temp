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
    public class EquipCompController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public EquipCompController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/EquipComps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipComp>>> GetEquipComp()
        {
            return await _context.EquipComp.ToListAsync();
        }

        // GET: api/EquipComps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipComp>> GetEquipComp(decimal id)
        {
            var equipComp = await _context.EquipComp.FindAsync(id);

            if (equipComp == null)
            {
                return NotFound();
            }

            return equipComp;
        }

        // PUT: api/EquipComps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipComp(decimal id, EquipComp equipComp)
        {
            if (id != equipComp.Counter)
            {
                return BadRequest();
            }

            _context.Entry(equipComp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipCompExists(id))
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

        // POST: api/EquipComps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EquipComp>> PostEquipComp(EquipComp equipComp)
        {
            _context.EquipComp.Add(equipComp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipComp", new { id = equipComp.Counter }, equipComp);
        }

        // DELETE: api/EquipComps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EquipComp>> DeleteEquipComp(decimal id)
        {
            var equipComp = await _context.EquipComp.FindAsync(id);
            if (equipComp == null)
            {
                return NotFound();
            }

            _context.EquipComp.Remove(equipComp);
            await _context.SaveChangesAsync();

            return equipComp;
        }

        private bool EquipCompExists(decimal id)
        {
            return _context.EquipComp.Any(e => e.Counter == id);
        }
    }
}
