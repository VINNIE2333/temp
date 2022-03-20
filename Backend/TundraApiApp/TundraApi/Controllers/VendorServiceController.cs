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
    public class VendorServiceController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public VendorServiceController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/VendorService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendorService>>> GetVendorService()
        {
            return await _context.VendorService.ToListAsync();
        }

        // GET: api/VendorServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendorService>> GetVendorService(int id)
        {
            var vendorService = await _context.VendorService.FindAsync(id);

            if (vendorService == null)
            {
                return NotFound();
            }

            return vendorService;
        }

        // PUT: api/VendorServices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendorService(int id, VendorService vendorService)
        {
            if (id != vendorService.Id)
            {
                return BadRequest();
            }

            _context.Entry(vendorService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorServiceExists(id))
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

        // POST: api/VendorServices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VendorService>> PostVendorService(VendorService vendorService)
        {
            _context.VendorService.Add(vendorService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendorService", new { id = vendorService.Id }, vendorService);
        }

        // DELETE: api/VendorServices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VendorService>> DeleteVendorService(int id)
        {
            var vendorService = await _context.VendorService.FindAsync(id);
            if (vendorService == null)
            {
                return NotFound();
            }

            _context.VendorService.Remove(vendorService);
            await _context.SaveChangesAsync();

            return vendorService;
        }

        private bool VendorServiceExists(int id)
        {
            return _context.VendorService.Any(e => e.Id == id);
        }
    }
}
