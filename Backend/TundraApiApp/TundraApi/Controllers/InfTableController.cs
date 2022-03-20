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
    public class InfTableController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InfTableController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InfTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfTable>>> GetInfTable()
        {
            return await _context.InfTable.ToListAsync();
        }

        // GET: api/InfTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InfTable>> GetInfTable(decimal id)
        {
            var infTable = await _context.InfTable.FindAsync(id);

            if (infTable == null)
            {
                return NotFound();
            }

            return infTable;
        }

        // PUT: api/InfTables/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfTable(decimal id, InfTable infTable)
        {
            if (id != infTable.Counter)
            {
                return BadRequest();
            }

            _context.Entry(infTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfTableExists(id))
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

        // POST: api/InfTables
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InfTable>> PostInfTable(InfTable infTable)
        {
            _context.InfTable.Add(infTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInfTable", new { id = infTable.Counter }, infTable);
        }

        // DELETE: api/InfTables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InfTable>> DeleteInfTable(decimal id)
        {
            var infTable = await _context.InfTable.FindAsync(id);
            if (infTable == null)
            {
                return NotFound();
            }

            _context.InfTable.Remove(infTable);
            await _context.SaveChangesAsync();

            return infTable;
        }

        private bool InfTableExists(decimal id)
        {
            return _context.InfTable.Any(e => e.Counter == id);
        }
    }
}
