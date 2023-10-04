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
    public class NomenclatureEtablissementsController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public NomenclatureEtablissementsController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/NomenclatureEtablissements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NomenclatureEtablissement>>> GetNomenclatureEtablissements()
        {
          if (_context.NomenclatureEtablissements == null)
          {
              return NotFound();
          }
            return await _context.NomenclatureEtablissements.ToListAsync();
        }

        // GET: api/NomenclatureEtablissements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NomenclatureEtablissement>> GetNomenclatureEtablissement(string id)
        {
          if (_context.NomenclatureEtablissements == null)
          {
              return NotFound();
          }
        var nomenclatureEtablissement = await _context.NomenclatureEtablissements.FindAsync(id);

        if (nomenclatureEtablissement == null)
        {
            return NotFound();
        }

        return nomenclatureEtablissement;
        }

        // PUT: api/NomenclatureEtablissements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNomenclatureEtablissement(string id, NomenclatureEtablissement nomenclatureEtablissement)
        {
            if (id != nomenclatureEtablissement.CodeEtab)
            {
                return BadRequest();
            }

            _context.Entry(nomenclatureEtablissement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NomenclatureEtablissementExists(id))
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

        // POST: api/NomenclatureEtablissements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NomenclatureEtablissement>> PostNomenclatureEtablissement(NomenclatureEtablissement nomenclatureEtablissement)
        {
          if (_context.NomenclatureEtablissements == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.NomenclatureEtablissements'  is null.");
          }
            _context.NomenclatureEtablissements.Add(nomenclatureEtablissement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NomenclatureEtablissementExists(nomenclatureEtablissement.CodeEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNomenclatureEtablissement", new { id = nomenclatureEtablissement.CodeEtab }, nomenclatureEtablissement);
        }

        // DELETE: api/NomenclatureEtablissements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNomenclatureEtablissement(string id)
        {
            if (_context.NomenclatureEtablissements == null)
            {
                return NotFound();
            }
            var nomenclatureEtablissement = await _context.NomenclatureEtablissements.FindAsync(id);
            if (nomenclatureEtablissement == null)
            {
                return NotFound();
            }

            _context.NomenclatureEtablissements.Remove(nomenclatureEtablissement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NomenclatureEtablissementExists(string id)
        {
            return (_context.NomenclatureEtablissements?.Any(e => e.CodeEtab == id)).GetValueOrDefault();
        }
    }
}
