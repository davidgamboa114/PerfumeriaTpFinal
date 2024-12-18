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
    public class AreaDeVentasController : ControllerBase
    {
        private readonly PerfumeriaContext _context;

        public AreaDeVentasController(PerfumeriaContext context)
        {
            _context = context;
        }

        // GET: api/AreaDeVentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaDeVenta>>> GetAreasDeVenta()
        {
            return await _context.pAreasDeVenta.ToListAsync();
        }

        // GET: api/AreaDeVentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AreaDeVenta>> GetAreaDeVenta(long id)
        {
            var areaDeVenta = await _context.pAreasDeVenta.FindAsync(id);

            if (areaDeVenta == null)
            {
                return NotFound();
            }

            return areaDeVenta;
        }

        // PUT: api/AreaDeVentas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAreaDeVenta(long id, AreaDeVenta areaDeVenta)
        {
            if (id != areaDeVenta.Id)
            {
                return BadRequest();
            }

            _context.Entry(areaDeVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaDeVentaExists(id))
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

        // POST: api/AreaDeVentas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AreaDeVenta>> PostAreaDeVenta(AreaDeVenta areaDeVenta)
        {
            _context.pAreasDeVenta.Add(areaDeVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAreaDeVenta", new { id = areaDeVenta.Id }, areaDeVenta);
        }

        // DELETE: api/AreaDeVentas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAreaDeVenta(long id)
        {
            var areaDeVenta = await _context.pAreasDeVenta.FindAsync(id);
            if (areaDeVenta == null)
            {
                return NotFound();
            }

            _context.pAreasDeVenta.Remove(areaDeVenta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AreaDeVentaExists(long id)
        {
            return _context.pAreasDeVenta.Any(e => e.Id == id);
        }
    }
}
