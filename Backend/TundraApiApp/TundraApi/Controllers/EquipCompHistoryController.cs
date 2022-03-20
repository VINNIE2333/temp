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
    public class EquipCompHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public EquipCompHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/EquipCompHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipCompHistory>>> GetEquipCompHistory()
        {
            return await _context.EquipCompHistory.ToListAsync();
        }

        // GET: api/EquipCompHistory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipCompHistory>> GetEquipCompHistory(string id)
        {
            var equipCompHistory = await _context.EquipCompHistory.FindAsync(id);

            if (equipCompHistory == null)
            {
                return NotFound();
            }

            return equipCompHistory;
        }

        // PUT: api/EquipCompHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipCompHistory(string id, EquipCompHistory equipCompHistory)
        {
            if (id != equipCompHistory.Equipment)
            {
                return BadRequest();
            }

            _context.Entry(equipCompHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipCompHistoryExists(id))
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

        // POST: api/EquipCompHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EquipCompHistory>> PostEquipCompHistory(EquipCompHistory equipCompHistory)
        {
            _context.EquipCompHistory.Add(equipCompHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EquipCompHistoryExists(equipCompHistory.Equipment))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEquipCompHistory", new { id = equipCompHistory.Equipment }, equipCompHistory);
        }

        // DELETE: api/EquipCompHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EquipCompHistory>> DeleteEquipCompHistory(string id)
        {
            var equipCompHistory = await _context.EquipCompHistory.FindAsync(id);
            if (equipCompHistory == null)
            {
                return NotFound();
            }

            _context.EquipCompHistory.Remove(equipCompHistory);
            await _context.SaveChangesAsync();

            return equipCompHistory;
        }

        private bool EquipCompHistoryExists(string id)
        {
            return _context.EquipCompHistory.Any(e => e.Equipment == id);
        }
    }
}
