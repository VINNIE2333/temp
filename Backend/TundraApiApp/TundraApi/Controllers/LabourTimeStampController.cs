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
    public class LabourTimeStampController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public LabourTimeStampController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/LabourTimeStamp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LabourTimeStamp>>> GetLabourTimeStamp()
        {
            return await _context.LabourTimeStamp.ToListAsync();
        }

        // GET: api/LabourTimeStamp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LabourTimeStamp>> GetLabourTimeStamp(int id)
        {
            var labourTimeStamp = await _context.LabourTimeStamp.FindAsync(id);

            if (labourTimeStamp == null)
            {
                return NotFound();
            }

            return labourTimeStamp;
        }

        // PUT: api/LabourTimeStamps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLabourTimeStamp(int id, LabourTimeStamp labourTimeStamp)
        {
            if (id != labourTimeStamp.Counter)
            {
                return BadRequest();
            }

            _context.Entry(labourTimeStamp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LabourTimeStampExists(id))
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

        // POST: api/LabourTimeStamps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LabourTimeStamp>> PostLabourTimeStamp(LabourTimeStamp labourTimeStamp)
        {
            _context.LabourTimeStamp.Add(labourTimeStamp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLabourTimeStamp", new { id = labourTimeStamp.Counter }, labourTimeStamp);
        }

        // DELETE: api/LabourTimeStamps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LabourTimeStamp>> DeleteLabourTimeStamp(int id)
        {
            var labourTimeStamp = await _context.LabourTimeStamp.FindAsync(id);
            if (labourTimeStamp == null)
            {
                return NotFound();
            }

            _context.LabourTimeStamp.Remove(labourTimeStamp);
            await _context.SaveChangesAsync();

            return labourTimeStamp;
        }

        private bool LabourTimeStampExists(int id)
        {
            return _context.LabourTimeStamp.Any(e => e.Counter == id);
        }
    }
}
