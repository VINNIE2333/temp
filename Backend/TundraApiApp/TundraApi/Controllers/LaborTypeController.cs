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
    public class LaborTypeController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public LaborTypeController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/LaborTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LaborType>>> GetLaborType()
        {
            return await _context.LaborType.ToListAsync();
        }

        // GET: api/LaborTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LaborType>> GetLaborType(string id)
        {
            var laborType = await _context.LaborType.FindAsync(id);

            if (laborType == null)
            {
                return NotFound();
            }

            return laborType;
        }

        // PUT: api/LaborTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLaborType(string id, LaborType laborType)
        {
            if (id != laborType.LabType)
            {
                return BadRequest();
            }

            _context.Entry(laborType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaborTypeExists(id))
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

        // POST: api/LaborTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LaborType>> PostLaborType(LaborType laborType)
        {
            _context.LaborType.Add(laborType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LaborTypeExists(laborType.LabType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLaborType", new { id = laborType.LabType }, laborType);
        }

        // DELETE: api/LaborTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LaborType>> DeleteLaborType(string id)
        {
            var laborType = await _context.LaborType.FindAsync(id);
            if (laborType == null)
            {
                return NotFound();
            }

            _context.LaborType.Remove(laborType);
            await _context.SaveChangesAsync();

            return laborType;
        }

        private bool LaborTypeExists(string id)
        {
            return _context.LaborType.Any(e => e.LabType == id);
        }
    }
}
