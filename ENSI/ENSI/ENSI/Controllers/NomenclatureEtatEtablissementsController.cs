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
    public class NomenclatureEtatEtablissementsController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public NomenclatureEtatEtablissementsController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/NomenclatureEtatEtablissements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NomenclatureEtatEtablissement>>> GetNomenclatureEtatEtablissements()
        {
          if (_context.NomenclatureEtatEtablissements == null)
          {
                return await _context.NomenclatureEtatEtablissements.ToListAsync();
               
          }
            return NotFound();
        }

        // GET: api/NomenclatureEtatEtablissements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NomenclatureEtatEtablissement>> GetNomenclatureEtatEtablissement(string id)
        {
          if (_context.NomenclatureEtatEtablissements == null)
          {
              return NotFound();
          }
            var nomenclatureEtatEtablissement = await _context.NomenclatureEtatEtablissements.FindAsync(id);

            if (nomenclatureEtatEtablissement == null)
            {
                return NotFound();
            }

            return nomenclatureEtatEtablissement;
        }

        // PUT: api/NomenclatureEtatEtablissements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNomenclatureEtatEtablissement(string id, NomenclatureEtatEtablissement nomenclatureEtatEtablissement)
        {
            if (id != nomenclatureEtatEtablissement.CodeEtatEtab)
            {
                return BadRequest();
            }

            _context.Entry(nomenclatureEtatEtablissement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NomenclatureEtatEtablissementExists(id))
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

        // POST: api/NomenclatureEtatEtablissements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NomenclatureEtatEtablissement>> PostNomenclatureEtatEtablissement(NomenclatureEtatEtablissement nomenclatureEtatEtablissement)
        {
          if (_context.NomenclatureEtatEtablissements == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.NomenclatureEtatEtablissements'  is null.");
          }
            _context.NomenclatureEtatEtablissements.Add(nomenclatureEtatEtablissement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NomenclatureEtatEtablissementExists(nomenclatureEtatEtablissement.CodeEtatEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNomenclatureEtatEtablissement", new { id = nomenclatureEtatEtablissement.CodeEtatEtab }, nomenclatureEtatEtablissement);
        }

        // DELETE: api/NomenclatureEtatEtablissements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNomenclatureEtatEtablissement(string id)
        {
            if (_context.NomenclatureEtatEtablissements == null)
            {
                return NotFound();
            }
            var nomenclatureEtatEtablissement = await _context.NomenclatureEtatEtablissements.FindAsync(id);
            if (nomenclatureEtatEtablissement == null)
            {
                return NotFound();
            }

            _context.NomenclatureEtatEtablissements.Remove(nomenclatureEtatEtablissement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NomenclatureEtatEtablissementExists(string id)
        {
            return (_context.NomenclatureEtatEtablissements?.Any(e => e.CodeEtatEtab == id)).GetValueOrDefault();
        }
    }
}
