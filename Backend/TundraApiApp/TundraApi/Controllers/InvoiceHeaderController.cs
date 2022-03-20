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
    public class InvoiceHeaderController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InvoiceHeaderController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceHeader>>> GetInvoiceHeader()
        {
            return await _context.InvoiceHeader.ToListAsync();
        }

        // GET: api/InvoiceHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceHeader>> GetInvoiceHeader(string id)
        {
            var invoiceHeader = await _context.InvoiceHeader.FindAsync(id);

            if (invoiceHeader == null)
            {
                return NotFound();
            }

            return invoiceHeader;
        }

        // PUT: api/InvoiceHeaders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceHeader(string id, InvoiceHeader invoiceHeader)
        {
            if (id != invoiceHeader.InvoiceNo)
            {
                return BadRequest();
            }

            _context.Entry(invoiceHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceHeaderExists(id))
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

        // POST: api/InvoiceHeaders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvoiceHeader>> PostInvoiceHeader(InvoiceHeader invoiceHeader)
        {
            _context.InvoiceHeader.Add(invoiceHeader);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InvoiceHeaderExists(invoiceHeader.InvoiceNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInvoiceHeader", new { id = invoiceHeader.InvoiceNo }, invoiceHeader);
        }

        // DELETE: api/InvoiceHeaders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceHeader>> DeleteInvoiceHeader(string id)
        {
            var invoiceHeader = await _context.InvoiceHeader.FindAsync(id);
            if (invoiceHeader == null)
            {
                return NotFound();
            }

            _context.InvoiceHeader.Remove(invoiceHeader);
            await _context.SaveChangesAsync();

            return invoiceHeader;
        }

        private bool InvoiceHeaderExists(string id)
        {
            return _context.InvoiceHeader.Any(e => e.InvoiceNo == id);
        }
    }
}
