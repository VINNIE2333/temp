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
    public class MileageController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public MileageController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Mileage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mileage>>> GetMileage()
        {
            return await _context.Mileage.ToListAsync();
        }

        // GET: api/Mileages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mileage>> GetMileage(decimal id)
        {
            var mileage = await _context.Mileage.FindAsync(id);

            if (mileage == null)
            {
                return NotFound();
            }

            return mileage;
        }

        // PUT: api/Mileages/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMileage(decimal id, Mileage mileage)
        {
            if (id != mileage.Counter)
            {
                return BadRequest();
            }

            _context.Entry(mileage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MileageExists(id))
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

        // POST: api/Mileages
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Mileage>> PostMileage(Mileage mileage)
        {
            _context.Mileage.Add(mileage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMileage", new { id = mileage.Counter }, mileage);
        }

        // DELETE: api/Mileages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mileage>> DeleteMileage(decimal id)
        {
            var mileage = await _context.Mileage.FindAsync(id);
            if (mileage == null)
            {
                return NotFound();
            }

            _context.Mileage.Remove(mileage);
            await _context.SaveChangesAsync();

            return mileage;
        }

        private bool MileageExists(decimal id)
        {
            return _context.Mileage.Any(e => e.Counter == id);
        }
    }
}
