using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PerfumeriaBackend.DataContext;
using PerfumeriaServices.Models;

namespace PerfumeriaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pMetodoDePagosController : ControllerBase
    {
        private readonly PerfumeriaContext _context;

        public pMetodoDePagosController(PerfumeriaContext context)
        {
            _context = context;
        }

        // GET: api/MetodoDePagoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pMetodoDePago>>> GetMetodosDePago()
        {
            return await _context.pMetodosDePago.ToListAsync();
        }

        // GET: api/MetodoDePagoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pMetodoDePago>> GetMetodoDePago(long id)
        {
            var metodoDePago = await _context.pMetodosDePago.FindAsync(id);

            if (metodoDePago == null)
            {
                return NotFound();
            }

            return metodoDePago;
        }

        // PUT: api/MetodoDePagoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetodoDePago(long id, pMetodoDePago metodoDePago)
        {
            if (id != metodoDePago.Id)
            {
                return BadRequest();
            }

            _context.Entry(metodoDePago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetodoDePagoExists(id))
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

        // POST: api/MetodoDePagoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pMetodoDePago>> PostMetodoDePago(pMetodoDePago metodoDePago)
        {
            _context.pMetodosDePago.Add(metodoDePago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMetodoDePago", new { id = metodoDePago.Id }, metodoDePago);
        }

        // DELETE: api/MetodoDePagoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMetodoDePago(long id)
        {
            var metodoDePago = await _context.pMetodosDePago.FindAsync(id);
            if (metodoDePago == null)
            {
                return NotFound();
            }

            _context.pMetodosDePago.Remove(metodoDePago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MetodoDePagoExists(long id)
        {
            return _context.pMetodosDePago.Any(e => e.Id == id);
        }
    }
}
