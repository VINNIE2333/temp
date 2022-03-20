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
    public class LocationHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public LocationHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/LocationHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationHistory>>> GetLocationHistory()
        {
            return await _context.LocationHistory.ToListAsync();
        }

        // GET: api/LocationHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationHistory>> GetLocationHistory(string id)
        {
            var locationHistory = await _context.LocationHistory.FindAsync(id);

            if (locationHistory == null)
            {
                return NotFound();
            }

            return locationHistory;
        }

        // PUT: api/LocationHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocationHistory(string id, LocationHistory locationHistory)
        {
            if (id != locationHistory.Location)
            {
                return BadRequest();
            }

            _context.Entry(locationHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationHistoryExists(id))
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

        // POST: api/LocationHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LocationHistory>> PostLocationHistory(LocationHistory locationHistory)
        {
            _context.LocationHistory.Add(locationHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LocationHistoryExists(locationHistory.Location))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLocationHistory", new { id = locationHistory.Location }, locationHistory);
        }

        // DELETE: api/LocationHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationHistory>> DeleteLocationHistory(string id)
        {
            var locationHistory = await _context.LocationHistory.FindAsync(id);
            if (locationHistory == null)
            {
                return NotFound();
            }

            _context.LocationHistory.Remove(locationHistory);
            await _context.SaveChangesAsync();

            return locationHistory;
        }

        private bool LocationHistoryExists(string id)
        {
            return _context.LocationHistory.Any(e => e.Location == id);
        }
    }
}
