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
    public class PMController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public PMController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/PM
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pm>>> GetPM()
        {
            return await _context.PM.ToListAsync();
        }

        // GET: api/Pms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pm>> GetPM(string id)
        {
            var pm = await _context.PM.FindAsync(id);

            if (pm == null)
            {
                return NotFound();
            }

            return pm;
        }

        // PUT: api/Pms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPM(string id, Pm pm)
        {
            if (id != pm.PmNum)
            {
                return BadRequest();
            }

            _context.Entry(pm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PmExists(id))
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

        // POST: api/Pms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pm>> PostPM(Pm pm)
        {
            _context.PM.Add(pm);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PmExists(pm.PmNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPm", new { id = pm.PmNum }, pm);
        }

        // DELETE: api/Pms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pm>> DeletePm(string id)
        {
            var pm = await _context.PM.FindAsync(id);
            if (pm == null)
            {
                return NotFound();
            }

            _context.PM.Remove(pm);
            await _context.SaveChangesAsync();

            return pm;
        }

        private bool PmExists(string id)
        {
            return _context.PM.Any(e => e.PmNum == id);
        }
    }
}
