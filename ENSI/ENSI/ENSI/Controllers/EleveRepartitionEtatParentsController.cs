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
    public class EleveRepartitionEtatParentsController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public EleveRepartitionEtatParentsController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/EleveRepartitionEtatParents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EleveRepartitionEtatParent>>> GetEleveRepartitionEtatParents()
        {
          if (_context.EleveRepartitionEtatParents == null)
          {
              return NotFound();
          }
            return await _context.EleveRepartitionEtatParents.ToListAsync();
        }

        // GET: api/EleveRepartitionEtatParents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EleveRepartitionEtatParent>> GetEleveRepartitionEtatParent(string id)
        {
          if (_context.EleveRepartitionEtatParents == null)
          {
              return NotFound();
          }
            var eleveRepartitionEtatParent = await _context.EleveRepartitionEtatParents.FindAsync(id);

            if (eleveRepartitionEtatParent == null)
            {
                return NotFound();
            }

            return eleveRepartitionEtatParent;
        }

        // PUT: api/EleveRepartitionEtatParents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEleveRepartitionEtatParent(string id, EleveRepartitionEtatParent eleveRepartitionEtatParent)
        {
            if (id != eleveRepartitionEtatParent.CodeEtab)
            {
                return BadRequest();
            }

            _context.Entry(eleveRepartitionEtatParent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EleveRepartitionEtatParentExists(id))
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

        // POST: api/EleveRepartitionEtatParents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EleveRepartitionEtatParent>> PostEleveRepartitionEtatParent(EleveRepartitionEtatParent eleveRepartitionEtatParent)
        {
          if (_context.EleveRepartitionEtatParents == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.EleveRepartitionEtatParents'  is null.");
          }
            _context.EleveRepartitionEtatParents.Add(eleveRepartitionEtatParent);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EleveRepartitionEtatParentExists(eleveRepartitionEtatParent.CodeEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEleveRepartitionEtatParent", new { id = eleveRepartitionEtatParent.CodeEtab }, eleveRepartitionEtatParent);
        }

        // DELETE: api/EleveRepartitionEtatParents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEleveRepartitionEtatParent(string id)
        {
            if (_context.EleveRepartitionEtatParents == null)
            {
                return NotFound();
            }
            var eleveRepartitionEtatParent = await _context.EleveRepartitionEtatParents.FindAsync(id);
            if (eleveRepartitionEtatParent == null)
            {
                return NotFound();
            }

            _context.EleveRepartitionEtatParents.Remove(eleveRepartitionEtatParent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EleveRepartitionEtatParentExists(string id)
        {
            return (_context.EleveRepartitionEtatParents?.Any(e => e.CodeEtab == id)).GetValueOrDefault();
        }
    }
}
