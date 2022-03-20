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
    public class SpecificationController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public SpecificationController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Specification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Specification>>> GetSpecification()
        {
            return await _context.Specification.ToListAsync();
        }

        // GET: api/Specifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Specification>> GetSpecification(decimal id)
        {
            var specification = await _context.Specification.FindAsync(id);

            if (specification == null)
            {
                return NotFound();
            }

            return specification;
        }

        // PUT: api/Specifications/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecification(decimal id, Specification specification)
        {
            if (id != specification.Counter)
            {
                return BadRequest();
            }

            _context.Entry(specification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecificationExists(id))
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

        // POST: api/Specifications
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Specification>> PostSpecification(Specification specification)
        {
            _context.Specification.Add(specification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecification", new { id = specification.Counter }, specification);
        }

        // DELETE: api/Specifications/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Specification>> DeleteSpecification(decimal id)
        {
            var specification = await _context.Specification.FindAsync(id);
            if (specification == null)
            {
                return NotFound();
            }

            _context.Specification.Remove(specification);
            await _context.SaveChangesAsync();

            return specification;
        }

        private bool SpecificationExists(decimal id)
        {
            return _context.Specification.Any(e => e.Counter == id);
        }
    }
}
