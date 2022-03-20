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
    public class LinkController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public LinkController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Link
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Link>>> GetLink()
        {
            return await _context.Link.ToListAsync();
        }

        // GET: api/Link/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Link>> GetLink(decimal id)
        {
            var link = await _context.Link.FindAsync(id);

            if (link == null)
            {
                return NotFound();
            }

            return link;
        }

        // PUT: api/Links/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLink(decimal id, Link link)
        {
            if (id != link.Counter)
            {
                return BadRequest();
            }

            _context.Entry(link).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinkExists(id))
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

        // POST: api/Links
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Link>> PostLink(Link link)
        {
            _context.Link.Add(link);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLink", new { id = link.Counter }, link);
        }

        // DELETE: api/Links/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Link>> DeleteLink(decimal id)
        {
            var link = await _context.Link.FindAsync(id);
            if (link == null)
            {
                return NotFound();
            }

            _context.Link.Remove(link);
            await _context.SaveChangesAsync();

            return link;
        }

        private bool LinkExists(decimal id)
        {
            return _context.Link.Any(e => e.Counter == id);
        }
    }
}
