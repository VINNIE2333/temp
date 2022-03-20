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
    public class InvMainController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InvMainController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InvMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvMain>>> GetInvMain()
        {
            return await _context.InvMain.ToListAsync();
        }

        // GET: api/InvMains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvMain>> GetInvMain(int id)
        {
            var invMain = await _context.InvMain.FindAsync(id);

            if (invMain == null)
            {
                return NotFound();
            }

            return invMain;
        }

        // PUT: api/InvMains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvMain(int id, InvMain invMain)
        {
            if (id != invMain.Counter)
            {
                return BadRequest();
            }

            _context.Entry(invMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvMainExists(id))
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

        // POST: api/InvMains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvMain>> PostInvMain(InvMain invMain)
        {
            _context.InvMain.Add(invMain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvMain", new { id = invMain.Counter }, invMain);
        }

        // DELETE: api/InvMains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvMain>> DeleteInvMain(int id)
        {
            var invMain = await _context.InvMain.FindAsync(id);
            if (invMain == null)
            {
                return NotFound();
            }

            _context.InvMain.Remove(invMain);
            await _context.SaveChangesAsync();

            return invMain;
        }

        private bool InvMainExists(int id)
        {
            return _context.InvMain.Any(e => e.Counter == id);
        }
    }
}
