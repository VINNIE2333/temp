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
    public class ManufacturerItemController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ManufacturerItemController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/ManufacturerItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ManufacturerItem>>> GetManufacturerItem()
        {
            return await _context.ManufacturerItem.ToListAsync();
        }

        // GET: api/ManufacturerItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ManufacturerItem>> GetManufacturerItem(string id)
        {
            var manufacturerItem = await _context.ManufacturerItem.FindAsync(id);

            if (manufacturerItem == null)
            {
                return NotFound();
            }

            return manufacturerItem;
        }

        // PUT: api/ManufacturerItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacturerItem(string id, ManufacturerItem manufacturerItem)
        {
            if (id != manufacturerItem.Manufacturer)
            {
                return BadRequest();
            }

            _context.Entry(manufacturerItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacturerItemExists(id))
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

        // POST: api/ManufacturerItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ManufacturerItem>> PostManufacturerItem(ManufacturerItem manufacturerItem)
        {
            _context.ManufacturerItem.Add(manufacturerItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ManufacturerItemExists(manufacturerItem.Manufacturer))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetManufacturerItem", new { id = manufacturerItem.Manufacturer }, manufacturerItem);
        }

        // DELETE: api/ManufacturerItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ManufacturerItem>> DeleteManufacturerItem(string id)
        {
            var manufacturerItem = await _context.ManufacturerItem.FindAsync(id);
            if (manufacturerItem == null)
            {
                return NotFound();
            }

            _context.ManufacturerItem.Remove(manufacturerItem);
            await _context.SaveChangesAsync();

            return manufacturerItem;
        }

        private bool ManufacturerItemExists(string id)
        {
            return _context.ManufacturerItem.Any(e => e.Manufacturer == id);
        }
    }
}
