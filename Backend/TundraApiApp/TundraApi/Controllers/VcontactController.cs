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
    public class VcontactController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public VcontactController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Vcontact
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vcontact>>> GetVContact()
        {
            return await _context.VContact.ToListAsync();
        }

        // GET: api/Vcontact/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vcontact>> GetVcontact(int id)
        {
            var vcontact = await _context.VContact.FindAsync(id);

            if (vcontact == null)
            {
                return NotFound();
            }

            return vcontact;
        }

        // PUT: api/Vcontact/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVcontact(int id, Vcontact vcontact)
        {
            if (id != vcontact.Counter)
            {
                return BadRequest();
            }

            _context.Entry(vcontact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VcontactExists(id))
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

        // POST: api/Vcontact
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vcontact>> PostVcontact(Vcontact vcontact)
        {
            _context.VContact.Add(vcontact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVcontact", new { id = vcontact.Counter }, vcontact);
        }

        // DELETE: api/Vcontact/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vcontact>> DeleteVcontact(int id)
        {
            var vcontact = await _context.VContact.FindAsync(id);
            if (vcontact == null)
            {
                return NotFound();
            }

            _context.VContact.Remove(vcontact);
            await _context.SaveChangesAsync();

            return vcontact;
        }

        private bool VcontactExists(int id)
        {
            return _context.VContact.Any(e => e.Counter == id);
        }
    }
}
