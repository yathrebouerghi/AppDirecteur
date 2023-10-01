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
    public class ActiviteFichesController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;

        public ActiviteFichesController(DbToufoulaProdContext context)
        {
            _context = context;
        }

        // GET: api/ActiviteFiches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActiviteFiche>>> GetActiviteFiches()
        {
          if (_context.ActiviteFiches == null)
          {
              return NotFound();
          }
            return await _context.ActiviteFiches.ToListAsync();
        }

        // GET: api/ActiviteFiches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActiviteFiche>> GetActiviteFiche(int id)
        {
          if (_context.ActiviteFiches == null)
          {
              return NotFound();
          }
            var activiteFiche = await _context.ActiviteFiches.FindAsync(id);

            if (activiteFiche == null)
            {
                return NotFound();
            }

            return activiteFiche;
        }

        // PUT: api/ActiviteFiches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActiviteFiche(int id, ActiviteFiche activiteFiche)
        {
            if (id != activiteFiche.CodeAct)
            {
                return BadRequest();
            }

            _context.Entry(activiteFiche).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActiviteFicheExists(id))
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

        // POST: api/ActiviteFiches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActiviteFiche>> PostActiviteFiche(ActiviteFiche activiteFiche)
        {
          if (_context.ActiviteFiches == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.ActiviteFiches'  is null.");
          }
            _context.ActiviteFiches.Add(activiteFiche);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActiviteFicheExists(activiteFiche.CodeAct))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActiviteFiche", new { id = activiteFiche.CodeAct }, activiteFiche);
        }

        // DELETE: api/ActiviteFiches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActiviteFiche(int id)
        {
            if (_context.ActiviteFiches == null)
            {
                return NotFound();
            }
            var activiteFiche = await _context.ActiviteFiches.FindAsync(id);
            if (activiteFiche == null)
            {
                return NotFound();
            }

            _context.ActiviteFiches.Remove(activiteFiche);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActiviteFicheExists(int id)
        {
            return (_context.ActiviteFiches?.Any(e => e.CodeAct == id)).GetValueOrDefault();
        }
    }
}
