using ENSI.Interface;
using ENSI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENSI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecuriteDirecteurController : ControllerBase
    {
        private readonly IDirecteur _IDirecteur;
        public SecuriteDirecteurController(IDirecteur Directeur)
        {
            _IDirecteur = Directeur;
        }

        [HttpGet("{id}")]
        public ActionResult<SecuriteDirecteur> GetDirecteur(int id)
        {
            try
            {
                var directeur = _IDirecteur.GetById(id);

                if (directeur != null)
                {
                    return Ok(directeur);
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

        [HttpGet("login/{login}")]
        public ActionResult<SecuriteDirecteur> GetDirecteurByLogin(string login)
        {
            try
            {
                var directeur = _IDirecteur.GetByLogin(login);

                if (directeur != null)
                {
                    return Ok(directeur);
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

        [HttpPut("{id}")]
        public IActionResult Update(int id, SecuriteDirecteur model)
        {
            _IDirecteur.UpdatePWD(id, model);
            return Ok(new { message = "Directeur password updated successfully" });
        }
    }
}
