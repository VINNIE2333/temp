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
    public class CloseRemarksController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public CloseRemarksController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/CloseRemarks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CloseRemark>>> GetCloseRemarks()
        {
            return await _context.CloseRemarks.ToListAsync();
        }

        // GET: api/CloseRemarks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CloseRemark>> GetCloseRemark(string id)
        {
       
            var closeRemark = await _context.CloseRemarks.FindAsync(id);

            if (closeRemark == null)
            {
                return NotFound();
            }

            return closeRemark;
        }

        // PUT: api/CloseRemarks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCloseRemark(string id, CloseRemark closeRemark)
        {
            if (id != closeRemark.CloseRemCode)
            {
                return BadRequest();
            }

            _context.Entry(closeRemark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CloseRemarkExists(id))
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

        // POST: api/CloseRemarks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CloseRemark>> PostCloseRemark(CloseRemark closeRemark)
        {
            _context.CloseRemarks.Add(closeRemark);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CloseRemarkExists(closeRemark.CloseRemCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCloseRemark", new { id = closeRemark.CloseRemCode }, closeRemark);
        }

        // DELETE: api/CloseRemarks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CloseRemark>> DeleteCloseRemark(string id)
        {
         

            var closeRemark = await _context.CloseRemarks.FindAsync(id);
            if (closeRemark == null)
            {
                return NotFound();
            }

            _context.CloseRemarks.Remove(closeRemark);
            await _context.SaveChangesAsync();

            return closeRemark;
        }

        private bool CloseRemarkExists(string id)
        {
            return _context.CloseRemarks.Any(e => e.CloseRemCode == id);
        }
    }
}
