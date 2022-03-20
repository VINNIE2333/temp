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
    public class ItemRequestController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public ItemRequestController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/ItemRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemRequest>>> GetItemRequest()
        {
            return await _context.ItemRequest.ToListAsync();
        }

        // GET: api/ItemRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemRequest>> GetItemRequest(string id)
        {
            var itemRequest = await _context.ItemRequest.FindAsync(id);

            if (itemRequest == null)
            {
                return NotFound();
            }

            return itemRequest;
        }

        // PUT: api/ItemRequests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemRequest(string id, ItemRequest itemRequest)
        {
            if (id != itemRequest.ReqNum)
            {
                return BadRequest();
            }

            _context.Entry(itemRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemRequestExists(id))
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

        // POST: api/ItemRequest
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemRequest>> PostItemRequest(ItemRequest itemRequest)
        {
            _context.ItemRequest.Add(itemRequest);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemRequestExists(itemRequest.ReqNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemRequest", new { id = itemRequest.ReqNum }, itemRequest);
        }

        // DELETE: api/ItemRequest/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemRequest>> DeleteItemRequest(string id)
        {
            var itemRequest = await _context.ItemRequest.FindAsync(id);
            if (itemRequest == null)
            {
                return NotFound();
            }

            _context.ItemRequest.Remove(itemRequest);
            await _context.SaveChangesAsync();

            return itemRequest;
        }

        private bool ItemRequestExists(string id)
        {
            return _context.ItemRequest.Any(e => e.ReqNum == id);
        }
    }
}
