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
    public class ItemTypeController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ItemTypeController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/ItemType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemType>>> GetItemType()
        {
            return await _context.ItemType.ToListAsync();
        }

        // GET: api/ItemType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemType>> GetItemType(decimal id)
        {
            var itemType = await _context.ItemType.FindAsync(id);

            if (itemType == null)
            {
                return NotFound();
            }

            return itemType;
        }

        // PUT: api/ItemTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemType(decimal id, ItemType itemType)
        {
            if (id != itemType.Counter)
            {
                return BadRequest();
            }

            _context.Entry(itemType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemTypeExists(id))
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

        // POST: api/ItemTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemType>> PostItemType(ItemType itemType)
        {
            _context.ItemType.Add(itemType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemType", new { id = itemType.Counter }, itemType);
        }

        // DELETE: api/ItemTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemType>> DeleteItemType(decimal id)
        {
            var itemType = await _context.ItemType.FindAsync(id);
            if (itemType == null)
            {
                return NotFound();
            }

            _context.ItemType.Remove(itemType);
            await _context.SaveChangesAsync();

            return itemType;
        }

        private bool ItemTypeExists(decimal id)
        {
            return _context.ItemType.Any(e => e.Counter == id);
        }
    }
}
