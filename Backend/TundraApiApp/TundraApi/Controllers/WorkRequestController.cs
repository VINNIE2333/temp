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
    public class WorkRequestController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public WorkRequestController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/WorkRequest
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkRequest>>> GetWorkRequest()
        {
            return await _context.WorkRequest.ToListAsync();
        }

        // GET: api/WorkRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkRequest>> GetWorkRequest(string id)
        {
            var workRequest = await _context.WorkRequest.FindAsync(id);

            if (workRequest == null)
            {
                return NotFound();
            }

            return workRequest;
        }

        // PUT: api/WorkRequests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkRequest(string id, WorkRequest workRequest)
        {
            if (id != workRequest.Wrnum)
            {
                return BadRequest();
            }

            _context.Entry(workRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkRequestExists(id))
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

        // POST: api/WorkRequests
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WorkRequest>> PostWorkRequest(WorkRequest workRequest)
        {
            _context.WorkRequest.Add(workRequest);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WorkRequestExists(workRequest.Wrnum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWorkRequest", new { id = workRequest.Wrnum }, workRequest);
        }

        // DELETE: api/WorkRequests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WorkRequest>> DeleteWorkRequest(string id)
        {
            var workRequest = await _context.WorkRequest.FindAsync(id);
            if (workRequest == null)
            {
                return NotFound();
            }

            _context.WorkRequest.Remove(workRequest);
            await _context.SaveChangesAsync();

            return workRequest;
        }

        private bool WorkRequestExists(string id)
        {
            return _context.WorkRequest.Any(e => e.Wrnum == id);
        }
    }
}
