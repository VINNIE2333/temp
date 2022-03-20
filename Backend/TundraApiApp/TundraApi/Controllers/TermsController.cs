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
    public class TermsController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public TermsController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Terms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Term>>> GetTerms()
        {
            return await _context.Terms.ToListAsync();
        }

        // GET: api/Terms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Term>> GetTerm(string id)
        {
            var term = await _context.Terms.FindAsync(id);

            if (term == null)
            {
                return NotFound();
            }

            return term;
        }

        // PUT: api/Terms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTerm(string id, Term term)
        {
            if (id != term.Code)
            {
                return BadRequest();
            }

            _context.Entry(term).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermExists(id))
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

        // POST: api/Terms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Term>> PostTerm(Term term)
        {
            _context.Terms.Add(term);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TermExists(term.Code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTerm", new { id = term.Code }, term);
        }

        // DELETE: api/Terms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Term>> DeleteTerm(string id)
        {
            var term = await _context.Terms.FindAsync(id);
            if (term == null)
            {
                return NotFound();
            }

            _context.Terms.Remove(term);
            await _context.SaveChangesAsync();

            return term;
        }

        private bool TermExists(string id)
        {
            return _context.Terms.Any(e => e.Code == id);
        }
    }
}
