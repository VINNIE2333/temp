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
    public class ItemsHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ItemsHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/ItemsHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemsHistory>>> GetItemsHistory()
        {
            return await _context.ItemsHistory.ToListAsync();
        }

        // GET: api/ItemsHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemsHistory>> GetItemsHistory(string id)
        {
            var itemsHistory = await _context.ItemsHistory.FindAsync(id);

            if (itemsHistory == null)
            {
                return NotFound();
            }

            return itemsHistory;
        }

        // PUT: api/ItemsHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemsHistory(string id, ItemsHistory itemsHistory)
        {
            if (id != itemsHistory.ItemNum)
            {
                return BadRequest();
            }

            _context.Entry(itemsHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsHistoryExists(id))
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

        // POST: api/ItemsHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemsHistory>> PostItemsHistory(ItemsHistory itemsHistory)
        {
            _context.ItemsHistory.Add(itemsHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemsHistoryExists(itemsHistory.ItemNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemsHistory", new { id = itemsHistory.ItemNum }, itemsHistory);
        }

        // DELETE: api/ItemsHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemsHistory>> DeleteItemsHistory(string id)
        {
            var itemsHistory = await _context.ItemsHistory.FindAsync(id);
            if (itemsHistory == null)
            {
                return NotFound();
            }

            _context.ItemsHistory.Remove(itemsHistory);
            await _context.SaveChangesAsync();

            return itemsHistory;
        }

        private bool ItemsHistoryExists(string id)
        {
            return _context.ItemsHistory.Any(e => e.ItemNum == id);
        }
    }
}
