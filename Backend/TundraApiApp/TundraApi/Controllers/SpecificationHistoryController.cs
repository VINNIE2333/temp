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
    public class SpecificationHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public SpecificationHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/SpecificationHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecificationHistory>>> GetSpecificationHistory()
        {
            return await _context.SpecificationHistory.ToListAsync();
        }

        // GET: api/SpecificationHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpecificationHistory>> GetSpecificationHistory(int id)
        {
            var specificationHistory = await _context.SpecificationHistory.FindAsync(id);

            if (specificationHistory == null)
            {
                return NotFound();
            }

            return specificationHistory;
        }

        // PUT: api/SpecificationHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecificationHistory(int id, SpecificationHistory specificationHistory)
        {
            if (id != specificationHistory.Counter)
            {
                return BadRequest();
            }

            _context.Entry(specificationHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecificationHistoryExists(id))
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

        // POST: api/SpecificationHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SpecificationHistory>> PostSpecificationHistory(SpecificationHistory specificationHistory)
        {
            _context.SpecificationHistory.Add(specificationHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecificationHistory", new { id = specificationHistory.Counter }, specificationHistory);
        }

        // DELETE: api/SpecificationHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SpecificationHistory>> DeleteSpecificationHistory(int id)
        {
            var specificationHistory = await _context.SpecificationHistory.FindAsync(id);
            if (specificationHistory == null)
            {
                return NotFound();
            }

            _context.SpecificationHistory.Remove(specificationHistory);
            await _context.SaveChangesAsync();

            return specificationHistory;
        }

        private bool SpecificationHistoryExists(int id)
        {
            return _context.SpecificationHistory.Any(e => e.Counter == id);
        }
    }
}
