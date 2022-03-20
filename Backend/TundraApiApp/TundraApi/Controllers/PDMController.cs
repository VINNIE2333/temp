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
    public class PDMController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public PDMController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Pdms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pdm>>> GetPDM()
        {
            return await _context.PDM.ToListAsync();
        }

        // GET: api/Pdms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pdm>> GetPDM(string id)
        {
            var pdm = await _context.PDM.FindAsync(id);

            if (pdm == null)
            {
                return NotFound();
            }

            return pdm;
        }

        // PUT: api/Pdms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPDM(string id, Pdm pdm)
        {
            if (id != pdm.Pdmnum)
            {
                return BadRequest();
            }

            _context.Entry(pdm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PDMExists(id))
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

        // POST: api/Pdms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pdm>> PostPDM(Pdm pdm)
        {
            _context.PDM.Add(pdm);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PDMExists(pdm.Pdmnum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPdm", new { id = pdm.Pdmnum }, pdm);
        }

        // DELETE: api/Pdms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pdm>> DeletePDM(string id)
        {
            var pdm = await _context.PDM.FindAsync(id);
            if (pdm == null)
            {
                return NotFound();
            }

            _context.PDM.Remove(pdm);
            await _context.SaveChangesAsync();

            return pdm;
        }

        private bool PDMExists(string id)
        {
            return _context.PDM.Any(e => e.Pdmnum == id);
        }
    }
}
