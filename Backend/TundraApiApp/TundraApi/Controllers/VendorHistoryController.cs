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
    public class VendorHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public VendorHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/VendorHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendorHistory>>> GetVendorHistory()
        {
            return await _context.VendorHistory.ToListAsync();
        }

        // GET: api/VendorHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendorHistory>> GetVendorHistory(string id)
        {
            var vendorHistory = await _context.VendorHistory.FindAsync(id);

            if (vendorHistory == null)
            {
                return NotFound();
            }

            return vendorHistory;
        }

        // PUT: api/VendorHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendorHistory(string id, VendorHistory vendorHistory)
        {
            if (id != vendorHistory.CompanyCode)
            {
                return BadRequest();
            }

            _context.Entry(vendorHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorHistoryExists(id))
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

        // POST: api/VendorHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VendorHistory>> PostVendorHistory(VendorHistory vendorHistory)
        {
            _context.VendorHistory.Add(vendorHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VendorHistoryExists(vendorHistory.CompanyCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVendorHistory", new { id = vendorHistory.CompanyCode }, vendorHistory);
        }

        // DELETE: api/VendorHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VendorHistory>> DeleteVendorHistory(string id)
        {
            var vendorHistory = await _context.VendorHistory.FindAsync(id);
            if (vendorHistory == null)
            {
                return NotFound();
            }

            _context.VendorHistory.Remove(vendorHistory);
            await _context.SaveChangesAsync();

            return vendorHistory;
        }

        private bool VendorHistoryExists(string id)
        {
            return _context.VendorHistory.Any(e => e.CompanyCode == id);
        }
    }
}
