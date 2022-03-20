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
    public class CodesController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public CodesController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Codes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Code>>> GetCodes()
        {
            return await _context.Codes.ToListAsync();
        }

        // GET: api/Codes1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Code>> GetCode(string id)
        {
            string id1 = id.Split(',')[0];
            string id2 = id.Split(',')[1];

            var code = await _context.Codes.FindAsync(id1, id2);

            if (code == null)
            {
                return NotFound();
            }

            return code;
        }

        // PUT: api/Codes1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCode(string id, Code code)
        {
            string id1 = id.Split(',')[0];
            string id2 = id.Split(',')[1];

            if (id != code.Tfield)
            {
                return BadRequest();
            }

            _context.Entry(code).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeExists(id))
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

        // POST: api/Codes1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Code>> PostCode(Code code)
        {
            _context.Codes.Add(code);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CodeExists(code.Tfield))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCode", new { id = code.Tfield }, code);
        }

        // DELETE: api/Codes1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCode(string id)
        {
            string id1 = id.Split(',')[0];
            string id2 = id.Split(',')[1];

            var code = await _context.Codes.FindAsync(id1, id2);
            if (code == null)
            {
                return NotFound();
            }

            _context.Codes.Remove(code);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CodeExists(string id)
        {
            string id1 = id.Split(',')[0];
            string id2 = id.Split(',')[1];

            return _context.Codes.Any(e => e.Tfield == id);
        }
    }
}