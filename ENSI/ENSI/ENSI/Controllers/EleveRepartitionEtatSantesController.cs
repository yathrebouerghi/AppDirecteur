using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ENSI.Models;

namespace ENSI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EleveRepartitionEtatSantesController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public EleveRepartitionEtatSantesController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/EleveRepartitionEtatSantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EleveRepartitionEtatSante>>> GetEleveRepartitionEtatSantes()
        {
          if (_context.EleveRepartitionEtatSantes == null)
          {
              return NotFound();
          }
            return await _context.EleveRepartitionEtatSantes.ToListAsync();
        }

        // GET: api/EleveRepartitionEtatSantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EleveRepartitionEtatSante>> GetEleveRepartitionEtatSante(string id)
        {
          if (_context.EleveRepartitionEtatSantes == null)
          {
              return NotFound();
          }
            var eleveRepartitionEtatSante = await _context.EleveRepartitionEtatSantes.FindAsync(id);

            if (eleveRepartitionEtatSante == null)
            {
                return NotFound();
            }

            return eleveRepartitionEtatSante;
        }

        // PUT: api/EleveRepartitionEtatSantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEleveRepartitionEtatSante(string id, EleveRepartitionEtatSante eleveRepartitionEtatSante)
        {
            if (id != eleveRepartitionEtatSante.CodeEtab)
            {
                return BadRequest();
            }

            _context.Entry(eleveRepartitionEtatSante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EleveRepartitionEtatSanteExists(id))
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

        // POST: api/EleveRepartitionEtatSantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EleveRepartitionEtatSante>> PostEleveRepartitionEtatSante(EleveRepartitionEtatSante eleveRepartitionEtatSante)
        {
          if (_context.EleveRepartitionEtatSantes == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.EleveRepartitionEtatSantes'  is null.");
          }
            _context.EleveRepartitionEtatSantes.Add(eleveRepartitionEtatSante);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EleveRepartitionEtatSanteExists(eleveRepartitionEtatSante.CodeEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEleveRepartitionEtatSante", new { id = eleveRepartitionEtatSante.CodeEtab }, eleveRepartitionEtatSante);
        }

        // DELETE: api/EleveRepartitionEtatSantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEleveRepartitionEtatSante(string id)
        {
            if (_context.EleveRepartitionEtatSantes == null)
            {
                return NotFound();
            }
            var eleveRepartitionEtatSante = await _context.EleveRepartitionEtatSantes.FindAsync(id);
            if (eleveRepartitionEtatSante == null)
            {
                return NotFound();
            }

            _context.EleveRepartitionEtatSantes.Remove(eleveRepartitionEtatSante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EleveRepartitionEtatSanteExists(string id)
        {
            return (_context.EleveRepartitionEtatSantes?.Any(e => e.CodeEtab == id)).GetValueOrDefault();
        }
    }
}
