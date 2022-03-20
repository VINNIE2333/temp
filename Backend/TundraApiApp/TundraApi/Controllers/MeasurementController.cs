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
    public class MeasurementController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public MeasurementController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Measurement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Measurement>>> GetMeasurement()
        {
            return await _context.Measurement.ToListAsync();
        }

        // GET: api/Measurements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Measurement>> GetMeasurement(int id)
        {
            var measurement = await _context.Measurement.FindAsync(id);

            if (measurement == null)
            {
                return NotFound();
            }

            return measurement;
        }

        // PUT: api/Measurements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurement(int id, Measurement measurement)
        {
            if (id != measurement.Counter)
            {
                return BadRequest();
            }

            _context.Entry(measurement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeasurementExists(id))
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

        // POST: api/Measurements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Measurement>> PostMeasurement(Measurement measurement)
        {
            _context.Measurement.Add(measurement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeasurement", new { id = measurement.Counter }, measurement);
        }

        // DELETE: api/Measurements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Measurement>> DeleteMeasurement(int id)
        {
            var measurement = await _context.Measurement.FindAsync(id);
            if (measurement == null)
            {
                return NotFound();
            }

            _context.Measurement.Remove(measurement);
            await _context.SaveChangesAsync();

            return measurement;
        }

        private bool MeasurementExists(int id)
        {
            return _context.Measurement.Any(e => e.Counter == id);
        }
    }
}
