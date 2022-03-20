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
    public class POController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public POController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/PO
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Po>>> GetPO()
        {
            return await _context.PO.ToListAsync();
        }

        // GET: api/Pos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Po>> GetPO(string id)
        {
            var po = await _context.PO.FindAsync(id);

            if (po == null)
            {
                return NotFound();
            }

            return po;
        }

        // PUT: api/Pos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPO(string id, Po po)
        {
            if (id != po.PoNum)
            {
                return BadRequest();
            }

            _context.Entry(po).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POExists(id))
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

        // POST: api/Pos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Po>> PostPO(Po po)
        {
            _context.PO.Add(po);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (POExists(po.PoNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPo", new { id = po.PoNum }, po);
        }

        // DELETE: api/Pos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Po>> DeletePO(string id)
        {
            var po = await _context.PO.FindAsync(id);
            if (po == null)
            {
                return NotFound();
            }

            _context.PO.Remove(po);
            await _context.SaveChangesAsync();

            return po;
        }

        private bool POExists(string id)
        {
            return _context.PO.Any(e => e.PoNum == id);
        }
    }
}
