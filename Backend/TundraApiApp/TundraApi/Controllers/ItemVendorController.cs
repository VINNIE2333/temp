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
    public class ItemVendorController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ItemVendorController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/ItemVendors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemVendor>>> GetItemVendor()
        {
            return await _context.ItemVendor.ToListAsync();
        }

        // GET: api/ItemVendors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemVendor>> GetItemVendor(decimal id)
        {
            var itemVendor = await _context.ItemVendor.FindAsync(id);

            if (itemVendor == null)
            {
                return NotFound();
            }

            return itemVendor;
        }

        // PUT: api/ItemVendors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemVendor(decimal id, ItemVendor itemVendor)
        {
            if (id != itemVendor.Counter)
            {
                return BadRequest();
            }

            _context.Entry(itemVendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemVendorExists(id))
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

        // POST: api/ItemVendors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemVendor>> PostItemVendor(ItemVendor itemVendor)
        {
            _context.ItemVendor.Add(itemVendor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemVendor", new { id = itemVendor.Counter }, itemVendor);
        }

        // DELETE: api/ItemVendors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemVendor>> DeleteItemVendor(decimal id)
        {
            var itemVendor = await _context.ItemVendor.FindAsync(id);
            if (itemVendor == null)
            {
                return NotFound();
            }

            _context.ItemVendor.Remove(itemVendor);
            await _context.SaveChangesAsync();

            return itemVendor;
        }

        private bool ItemVendorExists(decimal id)
        {
            return _context.ItemVendor.Any(e => e.Counter == id);
        }
    }
}
