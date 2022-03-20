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
    public class CostAccountsController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public CostAccountsController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/CostAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CostAccount>>> GetCostAccounts()
        {
            return await _context.CostAccounts.ToListAsync();
        }

        // GET: api/CostAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CostAccount>> GetCostAccount(int id)
        {

            var costAccount = await _context.CostAccounts.FindAsync(id);

            if (costAccount == null)
            {
                return NotFound();
            }

            return costAccount;
        }

        // PUT: api/CostAccounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCostAccount(int id, CostAccount costAccount)
        {
            if (id != costAccount.Counter)
            {
                return BadRequest();
            }

            _context.Entry(costAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostAccountExists(id))
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

        // POST: api/CostAccounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CostAccount>> PostCostAccount(CostAccount costAccount)
        {
            _context.CostAccounts.Add(costAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCostAccount", new { id = costAccount.Counter }, costAccount);
        }

        // DELETE: api/CostAccounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CostAccount>> DeleteCostAccount(int id)
        {
            var costAccount = await _context.CostAccounts.FindAsync(id);
            if (costAccount == null)
            {
                return NotFound();
            }

            _context.CostAccounts.Remove(costAccount);
            await _context.SaveChangesAsync();

            return costAccount;
        }

        private bool CostAccountExists(int id)
        {
            return _context.CostAccounts.Any(e => e.Counter == id);
        }
    }
}
