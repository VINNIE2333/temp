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
    public class InvoiceDetailController : ControllerBase
    {
        private readonly TundraDBContext _context;

        public InvoiceDetailController(TundraDBContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceDetail>>> GetInvoiceDetail()
        {
            return await _context.InvoiceDetail.ToListAsync();
        }

        // GET: api/InvoiceDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDetail>> GetInvoiceDetail(decimal id)
        {
            var invoiceDetail = await _context.InvoiceDetail.FindAsync(id);

            if (invoiceDetail == null)
            {
                return NotFound();
            }

            return invoiceDetail;
        }

        // PUT: api/InvoiceDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceDetail(decimal id, InvoiceDetail invoiceDetail)
        {
            if (id != invoiceDetail.Counter)
            {
                return BadRequest();
            }

            _context.Entry(invoiceDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceDetailExists(id))
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

        // POST: api/InvoiceDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvoiceDetail>> PostInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _context.InvoiceDetail.Add(invoiceDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceDetail", new { id = invoiceDetail.Counter }, invoiceDetail);
        }

        // DELETE: api/InvoiceDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceDetail>> DeleteInvoiceDetail(decimal id)
        {
            var invoiceDetail = await _context.InvoiceDetail.FindAsync(id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            _context.InvoiceDetail.Remove(invoiceDetail);
            await _context.SaveChangesAsync();

            return invoiceDetail;
        }

        private bool InvoiceDetailExists(decimal id)
        {
            return _context.InvoiceDetail.Any(e => e.Counter == id);
        }
    }
}
