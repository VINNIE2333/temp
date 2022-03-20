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
    public class ManufacturerController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ManufacturerController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Manufacturer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manufacturer>>> GetManufacturer()
        {
            return await _context.Manufacturer.ToListAsync();
        }

        // GET: api/Manufacturers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Manufacturer>> GetManufacturer(string id)
        {
            var manufacturer = await _context.Manufacturer.FindAsync(id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            return manufacturer;
        }

        // PUT: api/Manufacturers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacturer(string id, Manufacturer manufacturer)
        {
            if (id != manufacturer.CompanyCode)
            {
                return BadRequest();
            }

            _context.Entry(manufacturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacturerExists(id))
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

        // POST: api/Manufacturers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Manufacturer>> PostManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturer.Add(manufacturer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ManufacturerExists(manufacturer.CompanyCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetManufacturer", new { id = manufacturer.CompanyCode }, manufacturer);
        }

        // DELETE: api/Manufacturers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Manufacturer>> DeleteManufacturer(string id)
        {
            var manufacturer = await _context.Manufacturer.FindAsync(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            _context.Manufacturer.Remove(manufacturer);
            await _context.SaveChangesAsync();

            return manufacturer;
        }

        private bool ManufacturerExists(string id)
        {
            return _context.Manufacturer.Any(e => e.CompanyCode == id);
        }
    }
}
