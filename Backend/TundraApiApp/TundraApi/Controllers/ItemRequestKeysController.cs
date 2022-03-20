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
    public class ItemRequestKeysController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ItemRequestKeysController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/ItemRequestKeys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemRequestKey>>> GetItemRequestKeys()
        {
            return await _context.ItemRequestKeys.ToListAsync();
        }

        // GET: api/ItemRequestKeys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemRequestKey>> GetItemRequestKey(int id)
        {
            var itemRequestKey = await _context.ItemRequestKeys.FindAsync(id);

            if (itemRequestKey == null)
            {
                return NotFound();
            }

            return itemRequestKey;
        }

        // PUT: api/ItemRequestKeys/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemRequestKey(int id, ItemRequestKey itemRequestKey)
        {
            if (id != itemRequestKey.Counter)
            {
                return BadRequest();
            }

            _context.Entry(itemRequestKey).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemRequestKeyExists(id))
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

        // POST: api/ItemRequestKeys
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemRequestKey>> PostItemRequestKey(ItemRequestKey itemRequestKey)
        {
            _context.ItemRequestKeys.Add(itemRequestKey);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemRequestKey", new { id = itemRequestKey.Counter }, itemRequestKey);
        }

        // DELETE: api/ItemRequestKeys/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemRequestKey>> DeleteItemRequestKey(int id)
        {
            var itemRequestKey = await _context.ItemRequestKeys.FindAsync(id);
            if (itemRequestKey == null)
            {
                return NotFound();
            }

            _context.ItemRequestKeys.Remove(itemRequestKey);
            await _context.SaveChangesAsync();

            return itemRequestKey;
        }

        private bool ItemRequestKeyExists(int id)
        {
            return _context.ItemRequestKeys.Any(e => e.Counter == id);
        }
    }
}
