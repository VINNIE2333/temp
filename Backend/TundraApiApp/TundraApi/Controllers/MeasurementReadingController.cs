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
    public class MeasurementReadingController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public MeasurementReadingController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/MeasurementReading
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeasurementReading>>> GetMeasurementReading()
        {
            return await _context.MeasurementReading.ToListAsync();
        }

        // GET: api/MeasurementReadings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MeasurementReading>> GetMeasurementReading(decimal id)
        {
            var measurementReading = await _context.MeasurementReading.FindAsync(id);

            if (measurementReading == null)
            {
                return NotFound();
            }

            return measurementReading;
        }

        // PUT: api/MeasurementReadings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurementReading(decimal id, MeasurementReading measurementReading)
        {
            if (id != measurementReading.Counter)
            {
                return BadRequest();
            }

            _context.Entry(measurementReading).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeasurementReadingExists(id))
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

        // POST: api/MeasurementReadings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MeasurementReading>> PostMeasurementReading(MeasurementReading measurementReading)
        {
            _context.MeasurementReading.Add(measurementReading);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeasurementReading", new { id = measurementReading.Counter }, measurementReading);
        }

        // DELETE: api/MeasurementReadings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MeasurementReading>> DeleteMeasurementReading(decimal id)
        {
            var measurementReading = await _context.MeasurementReading.FindAsync(id);
            if (measurementReading == null)
            {
                return NotFound();
            }

            _context.MeasurementReading.Remove(measurementReading);
            await _context.SaveChangesAsync();

            return measurementReading;
        }

        private bool MeasurementReadingExists(decimal id)
        {
            return _context.MeasurementReading.Any(e => e.Counter == id);
        }
    }
}
