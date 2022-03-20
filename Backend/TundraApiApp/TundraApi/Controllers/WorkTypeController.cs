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
    public class WorkTypeController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WorkTypeController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/WorkType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkType>>> GetWorkType()
        {
            return await _context.WorkType.ToListAsync();
        }

        // GET: api/WorkTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkType>> GetWorkType(string id)
        {
            var workType = await _context.WorkType.FindAsync(id);

            if (workType == null)
            {
                return NotFound();
            }

            return workType;
        }

        // PUT: api/WorkTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkType(string id, WorkType workType)
        {
            if (id != workType.Wotype)
            {
                return BadRequest();
            }

            _context.Entry(workType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkTypeExists(id))
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

        // POST: api/WorkTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WorkType>> PostWorkType(WorkType workType)
        {
            _context.WorkType.Add(workType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WorkTypeExists(workType.Wotype))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWorkType", new { id = workType.Wotype }, workType);
        }

        // DELETE: api/WorkTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WorkType>> DeleteWorkType(string id)
        {
            var workType = await _context.WorkType.FindAsync(id);
            if (workType == null)
            {
                return NotFound();
            }

            _context.WorkType.Remove(workType);
            await _context.SaveChangesAsync();

            return workType;
        }

        private bool WorkTypeExists(string id)
        {
            return _context.WorkType.Any(e => e.Wotype == id);
        }
    }
}
