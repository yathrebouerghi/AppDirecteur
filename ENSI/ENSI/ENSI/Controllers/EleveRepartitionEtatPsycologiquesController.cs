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
    public class EleveRepartitionEtatPsycologiquesController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public EleveRepartitionEtatPsycologiquesController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/EleveRepartitionEtatPsycologiques
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EleveRepartitionEtatPsycologique>>> GetEleveRepartitionEtatPsycologiques()
        {
          if (_context.EleveRepartitionEtatPsycologiques == null)
          {
              return NotFound();
          }
            return await _context.EleveRepartitionEtatPsycologiques.ToListAsync();
        }

        // GET: api/EleveRepartitionEtatPsycologiques/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EleveRepartitionEtatPsycologique>> GetEleveRepartitionEtatPsycologique(string id)
        {
          if (_context.EleveRepartitionEtatPsycologiques == null)
          {
              return NotFound();
          }
            var eleveRepartitionEtatPsycologique = await _context.EleveRepartitionEtatPsycologiques.FindAsync(id);

            if (eleveRepartitionEtatPsycologique == null)
            {
                return NotFound();
            }

            return eleveRepartitionEtatPsycologique;
        }

        // PUT: api/EleveRepartitionEtatPsycologiques/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEleveRepartitionEtatPsycologique(string id, EleveRepartitionEtatPsycologique eleveRepartitionEtatPsycologique)
        {
            if (id != eleveRepartitionEtatPsycologique.CodeEtab)
            {
                return BadRequest();
            }

            _context.Entry(eleveRepartitionEtatPsycologique).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EleveRepartitionEtatPsycologiqueExists(id))
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

        // POST: api/EleveRepartitionEtatPsycologiques
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EleveRepartitionEtatPsycologique>> PostEleveRepartitionEtatPsycologique(EleveRepartitionEtatPsycologique eleveRepartitionEtatPsycologique)
        {
          if (_context.EleveRepartitionEtatPsycologiques == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.EleveRepartitionEtatPsycologiques'  is null.");
          }
            _context.EleveRepartitionEtatPsycologiques.Add(eleveRepartitionEtatPsycologique);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EleveRepartitionEtatPsycologiqueExists(eleveRepartitionEtatPsycologique.CodeEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEleveRepartitionEtatPsycologique", new { id = eleveRepartitionEtatPsycologique.CodeEtab }, eleveRepartitionEtatPsycologique);
        }

        // DELETE: api/EleveRepartitionEtatPsycologiques/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEleveRepartitionEtatPsycologique(string id)
        {
            if (_context.EleveRepartitionEtatPsycologiques == null)
            {
                return NotFound();
            }
            var eleveRepartitionEtatPsycologique = await _context.EleveRepartitionEtatPsycologiques.FindAsync(id);
            if (eleveRepartitionEtatPsycologique == null)
            {
                return NotFound();
            }

            _context.EleveRepartitionEtatPsycologiques.Remove(eleveRepartitionEtatPsycologique);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EleveRepartitionEtatPsycologiqueExists(string id)
        {
            return (_context.EleveRepartitionEtatPsycologiques?.Any(e => e.CodeEtab == id)).GetValueOrDefault();
        }
    }
}
