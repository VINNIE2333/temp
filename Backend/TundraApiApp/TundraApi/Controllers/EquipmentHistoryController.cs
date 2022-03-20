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
    public class EquipmentHistoryController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public EquipmentHistoryController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/EquipmentHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentHistory>>> GetEquipmentHistory()
        {
            return await _context.EquipmentHistory.ToListAsync();
        }

        // GET: api/EquipmentHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipmentHistory>> GetEquipmentHistory(string id)
        {
            var equipmentHistory = await _context.EquipmentHistory.FindAsync(id);

            if (equipmentHistory == null)
            {
                return NotFound();
            }

            return equipmentHistory;
        }

        // PUT: api/EquipmentHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipmentHistory(string id, EquipmentHistory equipmentHistory)
        {
            if (id != equipmentHistory.Equipment)
            {
                return BadRequest();
            }

            _context.Entry(equipmentHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentHistoryExists(id))
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

        // POST: api/EquipmentHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EquipmentHistory>> PostEquipmentHistory(EquipmentHistory equipmentHistory)
        {
            _context.EquipmentHistory.Add(equipmentHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EquipmentHistoryExists(equipmentHistory.Equipment))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEquipmentHistory", new { id = equipmentHistory.Equipment }, equipmentHistory);
        }

        // DELETE: api/EquipmentHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EquipmentHistory>> DeleteEquipmentHistory(string id)
        {
            var equipmentHistory = await _context.EquipmentHistory.FindAsync(id);
            if (equipmentHistory == null)
            {
                return NotFound();
            }

            _context.EquipmentHistory.Remove(equipmentHistory);
            await _context.SaveChangesAsync();

            return equipmentHistory;
        }

        private bool EquipmentHistoryExists(string id)
        {
            return _context.EquipmentHistory.Any(e => e.Equipment == id);
        }
    }
}
