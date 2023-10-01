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
    public class EleveRepartitionGroupeTrancheAgesController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public EleveRepartitionGroupeTrancheAgesController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/EleveRepartitionGroupeTrancheAges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EleveRepartitionGroupeTrancheAge>>> GetEleveRepartitionGroupeTrancheAges()
        {
          if (_context.EleveRepartitionGroupeTrancheAges == null)
          {
              return NotFound();
          }
            return await _context.EleveRepartitionGroupeTrancheAges.ToListAsync();
        }

        // GET: api/EleveRepartitionGroupeTrancheAges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EleveRepartitionGroupeTrancheAge>> GetEleveRepartitionGroupeTrancheAge(string id)
        {
          if (_context.EleveRepartitionGroupeTrancheAges == null)
          {
              return NotFound();
          }
            var eleveRepartitionGroupeTrancheAge = await _context.EleveRepartitionGroupeTrancheAges.FindAsync(id);

            if (eleveRepartitionGroupeTrancheAge == null)
            {
                return NotFound();
            }

            return eleveRepartitionGroupeTrancheAge;
        }

        // PUT: api/EleveRepartitionGroupeTrancheAges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEleveRepartitionGroupeTrancheAge(string id, EleveRepartitionGroupeTrancheAge eleveRepartitionGroupeTrancheAge)
        {
            if (id != eleveRepartitionGroupeTrancheAge.CodeEtab)
            {
                return BadRequest();
            }

            _context.Entry(eleveRepartitionGroupeTrancheAge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EleveRepartitionGroupeTrancheAgeExists(id))
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

        // POST: api/EleveRepartitionGroupeTrancheAges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EleveRepartitionGroupeTrancheAge>> PostEleveRepartitionGroupeTrancheAge(EleveRepartitionGroupeTrancheAge eleveRepartitionGroupeTrancheAge)
        {
          if (_context.EleveRepartitionGroupeTrancheAges == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.EleveRepartitionGroupeTrancheAges'  is null.");
          }
            _context.EleveRepartitionGroupeTrancheAges.Add(eleveRepartitionGroupeTrancheAge);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EleveRepartitionGroupeTrancheAgeExists(eleveRepartitionGroupeTrancheAge.CodeEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEleveRepartitionGroupeTrancheAge", new { id = eleveRepartitionGroupeTrancheAge.CodeEtab }, eleveRepartitionGroupeTrancheAge);
        }

        // DELETE: api/EleveRepartitionGroupeTrancheAges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEleveRepartitionGroupeTrancheAge(string id)
        {
            if (_context.EleveRepartitionGroupeTrancheAges == null)
            {
                return NotFound();
            }
            var eleveRepartitionGroupeTrancheAge = await _context.EleveRepartitionGroupeTrancheAges.FindAsync(id);
            if (eleveRepartitionGroupeTrancheAge == null)
            {
                return NotFound();
            }

            _context.EleveRepartitionGroupeTrancheAges.Remove(eleveRepartitionGroupeTrancheAge);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EleveRepartitionGroupeTrancheAgeExists(string id)
        {
            return (_context.EleveRepartitionGroupeTrancheAges?.Any(e => e.CodeEtab == id)).GetValueOrDefault();
        }
    }
}
