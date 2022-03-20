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
    public class EmployeeHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public EmployeeHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeHistory>>> GetEmployeeHistory()
        {
            return await _context.EmployeeHistory.ToListAsync();
        }

        // GET: api/EmployeeHistory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeHistory>> GetEmployeeHistory(string id)
        {
            var employeeHistory = await _context.EmployeeHistory.FindAsync(id);

            if (employeeHistory == null)
            {
                return NotFound();
            }

            return employeeHistory;
        }

        // PUT: api/EmployeeHistory/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeHistory(string id, EmployeeHistory employeeHistory)
        {
            if (id != employeeHistory.Empid)
            {
                return BadRequest();
            }

            _context.Entry(employeeHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeHistoryExists(id))
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

        // POST: api/EmployeeHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmployeeHistory>> PostEmployeeHistory(EmployeeHistory employeeHistory)
        {
            _context.EmployeeHistory.Add(employeeHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeHistoryExists(employeeHistory.Empid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployeeHistory", new { id = employeeHistory.Empid }, employeeHistory);
        }

        // DELETE: api/EmployeeHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeHistory>> DeleteEmployeeHistory(string id)
        {
            var employeeHistory = await _context.EmployeeHistory.FindAsync(id);
            if (employeeHistory == null)
            {
                return NotFound();
            }

            _context.EmployeeHistory.Remove(employeeHistory);
            await _context.SaveChangesAsync();

            return employeeHistory;
        }

        private bool EmployeeHistoryExists(string id)
        {
            return _context.EmployeeHistory.Any(e => e.Empid == id);
        }
    }
}
