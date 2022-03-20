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
    public class EQTypeController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public EQTypeController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Eqtypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eqtype>>> GetEQType()
        {
            return await _context.EQType.ToListAsync();
        }

        // GET: api/Eqtypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eqtype>> GetEQType(decimal id)
        {
            var eqtype = await _context.EQType.FindAsync(id);

            if (eqtype == null)
            {
                return NotFound();
            }

            return eqtype;
        }

        // PUT: api/Eqtypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEQType(decimal id, Eqtype eqtype)
        {
            if (id != eqtype.Counter)
            {
                return BadRequest();
            }

            _context.Entry(eqtype).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EqtypeExists(id))
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

        // POST: api/Eqtypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eqtype>> PostEQType(Eqtype eqtype)
        {
            _context.EQType.Add(eqtype);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEqtype", new { id = eqtype.Counter }, eqtype);
        }

        // DELETE: api/Eqtypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eqtype>> DeleteEqtype(decimal id)
        {
            var eqtype = await _context.EQType.FindAsync(id);
            if (eqtype == null)
            {
                return NotFound();
            }

            _context.EQType.Remove(eqtype);
            await _context.SaveChangesAsync();

            return eqtype;
        }

        private bool EqtypeExists(decimal id)
        {
            return _context.EQType.Any(e => e.Counter == id);
        }
    }
}
