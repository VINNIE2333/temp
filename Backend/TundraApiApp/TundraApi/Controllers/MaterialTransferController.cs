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
    public class MaterialTransferController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public MaterialTransferController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/MaterialTransfer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaterialTransfer>>> GetMaterialTransfer()
        {
            return await _context.MaterialTransfer.ToListAsync();
        }

        // GET: api/MaterialTransfers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MaterialTransfer>> GetMaterialTransfer(string id)
        {
            var materialTransfer = await _context.MaterialTransfer.FindAsync(id);

            if (materialTransfer == null)
            {
                return NotFound();
            }

            return materialTransfer;
        }

        // PUT: api/MaterialTransfers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterialTransfer(string id, MaterialTransfer materialTransfer)
        {
            if (id != materialTransfer.Mtnum)
            {
                return BadRequest();
            }

            _context.Entry(materialTransfer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialTransferExists(id))
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

        // POST: api/MaterialTransfers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MaterialTransfer>> PostMaterialTransfer(MaterialTransfer materialTransfer)
        {
            _context.MaterialTransfer.Add(materialTransfer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MaterialTransferExists(materialTransfer.Mtnum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMaterialTransfer", new { id = materialTransfer.Mtnum }, materialTransfer);
        }

        // DELETE: api/MaterialTransfers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MaterialTransfer>> DeleteMaterialTransfer(string id)
        {
            var materialTransfer = await _context.MaterialTransfer.FindAsync(id);
            if (materialTransfer == null)
            {
                return NotFound();
            }

            _context.MaterialTransfer.Remove(materialTransfer);
            await _context.SaveChangesAsync();

            return materialTransfer;
        }

        private bool MaterialTransferExists(string id)
        {
            return _context.MaterialTransfer.Any(e => e.Mtnum == id);
        }
    }
}
