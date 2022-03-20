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
    public class TransBatchController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public TransBatchController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/TransBatch
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransBatch>>> GetTransBatch()
        {
            return await _context.TransBatch.ToListAsync();
        }

        // GET: api/TransBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransBatch>> GetTransBatch(string id)
        {
            var transBatch = await _context.TransBatch.FindAsync(id);

            if (transBatch == null)
            {
                return NotFound();
            }

            return transBatch;
        }

        // PUT: api/TransBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransBatch(string id, TransBatch transBatch)
        {
            if (id != transBatch.BatchNum)
            {
                return BadRequest();
            }

            _context.Entry(transBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransBatchExists(id))
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

        // POST: api/TransBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TransBatch>> PostTransBatch(TransBatch transBatch)
        {
            _context.TransBatch.Add(transBatch);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TransBatchExists(transBatch.BatchNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTransBatch", new { id = transBatch.BatchNum }, transBatch);
        }

        // DELETE: api/TransBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TransBatch>> DeleteTransBatch(string id)
        {
            var transBatch = await _context.TransBatch.FindAsync(id);
            if (transBatch == null)
            {
                return NotFound();
            }

            _context.TransBatch.Remove(transBatch);
            await _context.SaveChangesAsync();

            return transBatch;
        }

        private bool TransBatchExists(string id)
        {
            return _context.TransBatch.Any(e => e.BatchNum == id);
        }
    }
}
