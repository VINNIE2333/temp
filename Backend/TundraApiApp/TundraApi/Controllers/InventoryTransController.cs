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
    public class InventoryTransController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InventoryTransController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InventoryTrans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryTran>>> GetInventoryTrans()
        {
            return await _context.InventoryTrans.ToListAsync();
        }

        // GET: api/InventoryTrans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryTran>> GetInventoryTran(decimal id)
        {
            var inventoryTran = await _context.InventoryTrans.FindAsync(id);

            if (inventoryTran == null)
            {
                return NotFound();
            }

            return inventoryTran;
        }

        // PUT: api/InventoryTrans/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryTran(decimal id, InventoryTran inventoryTran)
        {
            if (id != inventoryTran.Counter)
            {
                return BadRequest();
            }

            _context.Entry(inventoryTran).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryTranExists(id))
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

        // POST: api/InventoryTrans
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InventoryTran>> PostInventoryTran(InventoryTran inventoryTran)
        {
            _context.InventoryTrans.Add(inventoryTran);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventoryTran", new { id = inventoryTran.Counter }, inventoryTran);
        }

        // DELETE: api/InventoryTrans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InventoryTran>> DeleteInventoryTran(decimal id)
        {
            var inventoryTran = await _context.InventoryTrans.FindAsync(id);
            if (inventoryTran == null)
            {
                return NotFound();
            }

            _context.InventoryTrans.Remove(inventoryTran);
            await _context.SaveChangesAsync();

            return inventoryTran;
        }

        private bool InventoryTranExists(decimal id)
        {
            return _context.InventoryTrans.Any(e => e.Counter == id);
        }
    }
}
