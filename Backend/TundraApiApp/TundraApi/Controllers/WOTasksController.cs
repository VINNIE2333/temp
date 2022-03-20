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
    public class WOTasksController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WOTasksController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Wotasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wotask>>> GetWOTasks()
        {
            return await _context.WOTasks.ToListAsync();
        }

        // GET: api/Wotasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wotask>> GetWOTask(decimal id)
        {
            var wotask = await _context.WOTasks.FindAsync(id);

            if (wotask == null)
            {
                return NotFound();
            }

            return wotask;
        }

        // PUT: api/Wotasks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWOTask(decimal id, Wotask wotask)
        {
            if (id != wotask.Counter)
            {
                return BadRequest();
            }

            _context.Entry(wotask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WOTasksExists(id))
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

        // POST: api/Wotasks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Wotask>> PostWOTasks(Wotask wotask)
        {
            _context.WOTasks.Add(wotask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWotask", new { id = wotask.Counter }, wotask);
        }

        // DELETE: api/Wotasks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wotask>> DeleteWOTasks(decimal id)
        {
            var wotask = await _context.WOTasks.FindAsync(id);
            if (wotask == null)
            {
                return NotFound();
            }

            _context.WOTasks.Remove(wotask);
            await _context.SaveChangesAsync();

            return wotask;
        }

        private bool WOTasksExists(decimal id)
        {
            return _context.WOTasks.Any(e => e.Counter == id);
        }
    }
}
