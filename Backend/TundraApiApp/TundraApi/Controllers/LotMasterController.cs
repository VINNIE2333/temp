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
    public class LotMasterController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public LotMasterController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/LotMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LotMaster>>> GetLotMaster()
        {
            return await _context.LotMaster.ToListAsync();
        }

        // GET: api/LotMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LotMaster>> GetLotMaster(string id)
        {
            var lotMaster = await _context.LotMaster.FindAsync(id);

            if (lotMaster == null)
            {
                return NotFound();
            }

            return lotMaster;
        }

        // PUT: api/LotMasters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLotMaster(string id, LotMaster lotMaster)
        {
            if (id != lotMaster.LotNum)
            {
                return BadRequest();
            }

            _context.Entry(lotMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LotMasterExists(id))
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

        // POST: api/LotMasters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LotMaster>> PostLotMaster(LotMaster lotMaster)
        {
            _context.LotMaster.Add(lotMaster);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LotMasterExists(lotMaster.LotNum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLotMaster", new { id = lotMaster.LotNum }, lotMaster);
        }

        // DELETE: api/LotMasters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LotMaster>> DeleteLotMaster(string id)
        {
            var lotMaster = await _context.LotMaster.FindAsync(id);
            if (lotMaster == null)
            {
                return NotFound();
            }

            _context.LotMaster.Remove(lotMaster);
            await _context.SaveChangesAsync();

            return lotMaster;
        }

        private bool LotMasterExists(string id)
        {
            return _context.LotMaster.Any(e => e.LotNum == id);
        }
    }
}
