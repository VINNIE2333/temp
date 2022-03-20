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
    public class UserWorkListController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public UserWorkListController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/UserWorkList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserWorkList>>> GetUserWorkList()
        {
            return await _context.UserWorkList.ToListAsync();
        }

        // GET: api/UserWorkList/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserWorkList>> GetUserWorkList(int id)
        {
            var userWorkList = await _context.UserWorkList.FindAsync(id);

            if (userWorkList == null)
            {
                return NotFound();
            }

            return userWorkList;
        }

        // PUT: api/UserWorkList/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserWorkList(int id, UserWorkList userWorkList)
        {
            if (id != userWorkList.Counter)
            {
                return BadRequest();
            }

            _context.Entry(userWorkList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserWorkListExists(id))
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

        // POST: api/UserWorkList
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserWorkList>> PostUserWorkList(UserWorkList userWorkList)
        {
            _context.UserWorkList.Add(userWorkList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserWorkList", new { id = userWorkList.Counter }, userWorkList);
        }

        // DELETE: api/UserWorkList/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserWorkList>> DeleteUserWorkList(int id)
        {
            var userWorkList = await _context.UserWorkList.FindAsync(id);
            if (userWorkList == null)
            {
                return NotFound();
            }

            _context.UserWorkList.Remove(userWorkList);
            await _context.SaveChangesAsync();

            return userWorkList;
        }

        private bool UserWorkListExists(int id)
        {
            return _context.UserWorkList.Any(e => e.Counter == id);
        }
    }
}
