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
    public class InvCountDetailController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InvCountDetailController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InvCountDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvCountDetail>>> GetInvCountDetail()
        {
            return await _context.InvCountDetail.ToListAsync();
        }

        // GET: api/InvCountDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvCountDetail>> GetInvCountDetail(decimal id)
        {
            var invCountDetail = await _context.InvCountDetail.FindAsync(id);

            if (invCountDetail == null)
            {
                return NotFound();
            }

            return invCountDetail;
        }

        // PUT: api/InvCountDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvCountDetail(decimal id, InvCountDetail invCountDetail)
        {
            if (id != invCountDetail.Counter)
            {
                return BadRequest();
            }

            _context.Entry(invCountDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvCountDetailExists(id))
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

        // POST: api/InvCountDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvCountDetail>> PostInvCountDetail(InvCountDetail invCountDetail)
        {
            _context.InvCountDetail.Add(invCountDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvCountDetail", new { id = invCountDetail.Counter }, invCountDetail);
        }

        // DELETE: api/InvCountDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvCountDetail>> DeleteInvCountDetail(decimal id)
        {
            var invCountDetail = await _context.InvCountDetail.FindAsync(id);
            if (invCountDetail == null)
            {
                return NotFound();
            }

            _context.InvCountDetail.Remove(invCountDetail);
            await _context.SaveChangesAsync();

            return invCountDetail;
        }

        private bool InvCountDetailExists(decimal id)
        {
            return _context.InvCountDetail.Any(e => e.Counter == id);
        }
    }
}
