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
    public class BudgetTypeController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public BudgetTypeController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/BudgetTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BudgetType>>> GetBudgetType()
        {
            return await _context.BudgetType.ToListAsync();
        }

        // GET: api/BudgetTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BudgetType>> GetBudgetType(int id)
        {
            var budgetType = await _context.BudgetType.FindAsync(id);

            if (budgetType == null)
            {
                return NotFound();
            }

            return budgetType;
        }

        // PUT: api/BudgetTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBudgetType(int id, BudgetType budgetType)
        {
            if (id != budgetType.BudgetType1)
            {
                return BadRequest();
            }

            _context.Entry(budgetType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BudgetTypeExists(id))
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

        // POST: api/BudgetTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BudgetType>> PostBudgetType(BudgetType budgetType)
        {
            _context.BudgetType.Add(budgetType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBudgetType", new { id = budgetType.BudgetType1 }, budgetType);
        }

        // DELETE: api/BudgetTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BudgetType>> DeleteBudgetType(int id)
        {
            var budgetType = await _context.BudgetType.FindAsync(id);
            if (budgetType == null)
            {
                return NotFound();
            }

            _context.BudgetType.Remove(budgetType);
            await _context.SaveChangesAsync();

            return budgetType;
        }

        private bool BudgetTypeExists(int id)
        {
            return _context.BudgetType.Any(e => e.BudgetType1 == id);
        }
    }
}
