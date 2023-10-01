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
    public class EleveEleveHandicapsController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public EleveEleveHandicapsController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/EleveEleveHandicaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EleveEleveHandicap>>> GetEleveEleveHandicaps()
        {
          if (_context.EleveEleveHandicaps == null)
          {
              return NotFound();
          }
            return await _context.EleveEleveHandicaps.ToListAsync();
        }

        // GET: api/EleveEleveHandicaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EleveEleveHandicap>> GetEleveEleveHandicap(int id)
        {
          if (_context.EleveEleveHandicaps == null)
          {
              return NotFound();
          }
            var eleveEleveHandicap = await _context.EleveEleveHandicaps.FindAsync(id);

            if (eleveEleveHandicap == null)
            {
                return NotFound();
            }

            return eleveEleveHandicap;
        }

        // PUT: api/EleveEleveHandicaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEleveEleveHandicap(int id, EleveEleveHandicap eleveEleveHandicap)
        {
            if (id != eleveEleveHandicap.NumeElev)
            {
                return BadRequest();
            }

            _context.Entry(eleveEleveHandicap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EleveEleveHandicapExists(id))
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

        // POST: api/EleveEleveHandicaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EleveEleveHandicap>> PostEleveEleveHandicap(EleveEleveHandicap eleveEleveHandicap)
        {
          if (_context.EleveEleveHandicaps == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.EleveEleveHandicaps'  is null.");
          }
            _context.EleveEleveHandicaps.Add(eleveEleveHandicap);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EleveEleveHandicapExists(eleveEleveHandicap.NumeElev))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEleveEleveHandicap", new { id = eleveEleveHandicap.NumeElev }, eleveEleveHandicap);
        }

        // DELETE: api/EleveEleveHandicaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEleveEleveHandicap(int id)
        {
            if (_context.EleveEleveHandicaps == null)
            {
                return NotFound();
            }
            var eleveEleveHandicap = await _context.EleveEleveHandicaps.FindAsync(id);
            if (eleveEleveHandicap == null)
            {
                return NotFound();
            }

            _context.EleveEleveHandicaps.Remove(eleveEleveHandicap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EleveEleveHandicapExists(int id)
        {
            return (_context.EleveEleveHandicaps?.Any(e => e.NumeElev == id)).GetValueOrDefault();
        }
    }
}
