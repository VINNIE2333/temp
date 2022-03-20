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
    public class RouteController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public RouteController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/Route
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Route>>> GetRoute()
        {
            return await _context.Route.ToListAsync();
        }

        // GET: api/Routes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Route>> GetRoute(string id)
        {
            var route = await _context.Route.FindAsync(id);

            if (route == null)
            {
                return NotFound();
            }

            return route;
        }

        // PUT: api/Routes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoute(string id, Route route)
        {
            if (id != route.RouteName)
            {
                return BadRequest();
            }

            _context.Entry(route).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteExists(id))
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

        // POST: api/Routes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Route>> PostRoute(Route route)
        {
            _context.Route.Add(route);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RouteExists(route.RouteName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoute", new { id = route.RouteName }, route);
        }

        // DELETE: api/Routes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Route>> DeleteRoute(string id)
        {
            var route = await _context.Route.FindAsync(id);
            if (route == null)
            {
                return NotFound();
            }

            _context.Route.Remove(route);
            await _context.SaveChangesAsync();

            return route;
        }

        private bool RouteExists(string id)
        {
            return _context.Route.Any(e => e.RouteName == id);
        }
    }
}
