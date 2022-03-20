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
    public class RouteDetailController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public RouteDetailController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/RouteDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RouteDetail>>> GetRouteDetail()
        {
            return await _context.RouteDetail.ToListAsync();
        }

        // GET: api/RouteDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RouteDetail>> GetRouteDetail(decimal id)
        {
            var routeDetail = await _context.RouteDetail.FindAsync(id);

            if (routeDetail == null)
            {
                return NotFound();
            }

            return routeDetail;
        }

        // PUT: api/RouteDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRouteDetail(decimal id, RouteDetail routeDetail)
        {
            if (id != routeDetail.Counter)
            {
                return BadRequest();
            }

            _context.Entry(routeDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteDetailExists(id))
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

        // POST: api/RouteDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RouteDetail>> PostRouteDetail(RouteDetail routeDetail)
        {
            _context.RouteDetail.Add(routeDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRouteDetail", new { id = routeDetail.Counter }, routeDetail);
        }

        // DELETE: api/RouteDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RouteDetail>> DeleteRouteDetail(decimal id)
        {
            var routeDetail = await _context.RouteDetail.FindAsync(id);
            if (routeDetail == null)
            {
                return NotFound();
            }

            _context.RouteDetail.Remove(routeDetail);
            await _context.SaveChangesAsync();

            return routeDetail;
        }

        private bool RouteDetailExists(decimal id)
        {
            return _context.RouteDetail.Any(e => e.Counter == id);
        }
    }
}
