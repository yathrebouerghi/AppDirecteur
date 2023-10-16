using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ENSI.Models;
using ENSI.Interface;
using ENSI.Migrations;
using Microsoft.AspNetCore.Authorization;

namespace ENSI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelPersonnelsController : ControllerBase
    {
        private readonly DbToufoulaProdContext _context;
        private readonly IPersonnel _IPersonnel;

        public PersonnelPersonnelsController(DbToufoulaProdContext context, IPersonnel IPersonnel)
        {
            _context = context;
            _IPersonnel = IPersonnel;
        }

        // GET: api/PersonnelPersonnels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonnelPersonnel>>> GetPersonnelPersonnel()
        {
          if (_context.PersonnelPersonnel == null)
          {
              return NotFound();
          }
            return await _context.PersonnelPersonnel.ToListAsync();
        }

        // GET: api/PersonnelPersonnels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonnelPersonnel>> GetPersonnelPersonnel(string id)
        {
          if (_context.PersonnelPersonnel == null)
          {
              return NotFound();
          }
            var personnelPersonnel = await _context.PersonnelPersonnel.FindAsync(id);

            if (personnelPersonnel == null)
            {
                return NotFound();
            }

            return personnelPersonnel;
        }

        // PUT: api/PersonnelPersonnels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonnelPersonnel(string id, PersonnelPersonnel personnelPersonnel)
        {
            if (id != personnelPersonnel.CodeEtab)
            {
                return BadRequest();
            }

            _context.Entry(personnelPersonnel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonnelPersonnelExists(id))
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

        // POST: api/PersonnelPersonnels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonnelPersonnel>> PostPersonnelPersonnel(PersonnelPersonnel personnelPersonnel)
        {
          if (_context.PersonnelPersonnel == null)
          {
              return Problem("Entity set 'DbToufoulaProdContext.PersonnelPersonnel'  is null.");
          }
            _context.PersonnelPersonnel.Add(personnelPersonnel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PersonnelPersonnelExists(personnelPersonnel.CodeEtab))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPersonnelPersonnel", new { id = personnelPersonnel.CodeEtab }, personnelPersonnel);
        }

        // DELETE: api/PersonnelPersonnels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonnelPersonnel(string id)
        {
            if (_context.PersonnelPersonnel == null)
            {
                return NotFound();
            }
            var personnelPersonnel = await _context.PersonnelPersonnel.FindAsync(id);
            if (personnelPersonnel == null)
            {
                return NotFound();
            }

            _context.PersonnelPersonnel.Remove(personnelPersonnel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonnelPersonnelExists(string id)
        {
            return (_context.PersonnelPersonnel?.Any(e => e.CodeEtab == id)).GetValueOrDefault();
        }

        [HttpGet("{cin}")]
        public ActionResult<PersonnelPersonnel> GetPersonnel(string cin)
        {
            try
            {
                var personnel = _IPersonnel.GetPersonnelByidenUniq(cin);

                if (personnel != null)
                {
                    return Ok(personnel);
                }
                else
                {
                    return NotFound(); // Renvoie un code 404 si l'établissement n'est pas trouvé.
                }
            }
            catch (Exception ex)
            {
                // Gérez les exceptions ici, par exemple, en renvoyant une réponse d'erreur.
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

        [HttpGet("personnels/{codeEtab}")]
        public async Task<ActionResult<IEnumerable<PersonnelPersonnel>>> GetTypeEtablissement(string codeEtab)
        {
            var personnels = await Task.FromResult(_IPersonnel.GetPersonnelsByCodeEtabAsync(codeEtab));
            if (personnels.Count == 0)
            {
                return NotFound();
            }
            return personnels;
        }


        [HttpGet("genre/{codeGnere}")]
        public ActionResult<NomenclatureGenre> GetGenrByCode(string codeGnere)
        {
            try
            {
                var genre = _IPersonnel.getGenreByCode(codeGnere);

                if (genre != null)
                {
                    return Ok(genre);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

        [HttpGet("niveau/{codeNivEtd}")]
        public ActionResult<NomenclatureNiveauEtude> GetniveauEtdByCode(string codeNivEtd)
        {
            try
            {
                var niveauEtd = _IPersonnel.getNiveauEtdByCode(codeNivEtd);

                if (niveauEtd != null)
                {
                    return Ok(niveauEtd);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

        [HttpGet("situFami/{codeSitF}")]
        public ActionResult<NomenclatureSituationFamiliale> getSitFByCode(string codeSitF)
        {
            try
            {
                var situFami = _IPersonnel.getSitFByCode(codeSitF);

                if (situFami != null)
                {
                    return Ok(situFami);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

        [HttpGet("grade/{codeGrade}")]
        public ActionResult<NomenclatureGrade> getGradeByCode(string codeGrade)
        {
            try
            {
                var grade = _IPersonnel.getGradeByCode(codeGrade);

                if (grade != null)
                {
                    return Ok(grade);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

        [HttpGet("qualite/{codeQualite}")]
        public ActionResult<NomenclatureQualite> getQualiteByCode(string codeQualite)
        {
            try
            {
                var qualite = _IPersonnel.getQualiteByCode(codeQualite);

                if (qualite != null)
                {
                    return Ok(qualite);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

        [HttpGet("sitProf/{codesirProf}")]
        public ActionResult<NomenclatureSituationProfessionel> getSitProfByCode(string codesirProf)
        {
            try
            {
                var sitProf = _IPersonnel.getSitProdByCode(codesirProf);

                if (sitProf != null)
                {
                    return Ok(sitProf);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }
        [HttpGet("fonction/{codeFonction}")]
        public ActionResult<NomenclatureFonction> getFonctionByCode(string codeFonction)
        {
            try
            {
                var fonction = _IPersonnel.getFonctionByCode(codeFonction);

                if (fonction != null)
                {
                    return Ok(fonction);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }

    }
}
