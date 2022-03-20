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
    public class MeterReadingController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public MeterReadingController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/MeterReading
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeterReading>>> GetMeterReading()
        {
            return await _context.MeterReading.ToListAsync();
        }

        // GET: api/MeterReadings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MeterReading>> GetMeterReading(decimal id)
        {
            var meterReading = await _context.MeterReading.FindAsync(id);

            if (meterReading == null)
            {
                return NotFound();
            }

            return meterReading;
        }

        // PUT: api/MeterReadings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeterReading(decimal id, MeterReading meterReading)
        {
            if (id != meterReading.Counter)
            {
                return BadRequest();
            }

            _context.Entry(meterReading).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterReadingExists(id))
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

        // POST: api/MeterReadings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MeterReading>> PostMeterReading(MeterReading meterReading)
        {
            _context.MeterReading.Add(meterReading);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeterReading", new { id = meterReading.Counter }, meterReading);
        }

        // DELETE: api/MeterReadings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MeterReading>> DeleteMeterReading(decimal id)
        {
            var meterReading = await _context.MeterReading.FindAsync(id);
            if (meterReading == null)
            {
                return NotFound();
            }

            _context.MeterReading.Remove(meterReading);
            await _context.SaveChangesAsync();

            return meterReading;
        }

        private bool MeterReadingExists(decimal id)
        {
            return _context.MeterReading.Any(e => e.Counter == id);
        }
    }
}
