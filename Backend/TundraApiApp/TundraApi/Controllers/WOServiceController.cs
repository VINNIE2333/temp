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
    public class WOServiceController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WOServiceController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Woservices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Woservice>>> GetWOService()
        {
            return await _context.WOService.ToListAsync();
        }

        // GET: api/Woservices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Woservice>> GetWOService(int id)
        {
            var woservice = await _context.WOService.FindAsync(id);

            if (woservice == null)
            {
                return NotFound();
            }

            return woservice;
        }

        // PUT: api/Woservices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWOService(int id, Woservice woservice)
        {
            if (id != woservice.Counter)
            {
                return BadRequest();
            }

            _context.Entry(woservice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WOServiceExists(id))
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

        // POST: api/Woservices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Woservice>> PostWOService(Woservice woservice)
        {
            _context.WOService.Add(woservice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoservice", new { id = woservice.Counter }, woservice);
        }

        // DELETE: api/Woservices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Woservice>> DeleteWOService(int id)
        {
            var woservice = await _context.WOService.FindAsync(id);
            if (woservice == null)
            {
                return NotFound();
            }

            _context.WOService.Remove(woservice);
            await _context.SaveChangesAsync();

            return woservice;
        }

        private bool WOServiceExists(int id)
        {
            return _context.WOService.Any(e => e.Counter == id);
        }
    }
}
