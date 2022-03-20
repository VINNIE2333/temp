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
    public class BudgetController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public BudgetController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Budget
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Budget>>> GetBudget()
        {
            return await _context.Budgets.ToListAsync();
        }

        // GET: api/Budget/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Budget>> GetBudget(int id)
        {
            var budget = await _context.Budgets.FindAsync(id);

            if (budget == null)
            {
                return NotFound();
            }

            return budget;
        }

        // PUT: api/Budget/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBudget(int id, Budget budget)
        {
            if (id != budget.Counter)
            {
                return BadRequest();
            }

            _context.Entry(budget).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BudgetExists(id))
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

        // POST: api/Budget
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Budget>> PostBudget(Budget budget)
        {
            _context.Budgets.Add(budget);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBudget", new { id = budget.Counter }, budget);
        }

        // DELETE: api/Budget/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Budget>> DeleteBudget(int id)
        {
            var budget = await _context.Budgets.FindAsync(id);
            if (budget == null)
            {
                return NotFound();
            }

            _context.Budgets.Remove(budget);
            await _context.SaveChangesAsync();

            return budget;
        }

        private bool BudgetExists(int id)
        {
            return _context.Budgets.Any(e => e.Counter == id);
        }
    }
}
