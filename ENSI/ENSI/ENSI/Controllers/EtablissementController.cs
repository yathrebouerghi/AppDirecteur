using ENSI.Interface;
using ENSI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENSI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtablissementController : ControllerBase
    {
        private readonly IEtablissement _IEtablissement;

        public EtablissementController(IEtablissement IEtablissement)
        {
            _IEtablissement = IEtablissement;
        }
        // GET: api/etablissement>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewEtablissement>>> Get()
        {
            return await Task.FromResult(_IEtablissement.GetEtablissements());
        }
        [HttpGet("{LibeGouv}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetByLibeGouv(string LibeGouv)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeGouvAsync(LibeGouv));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }

        [HttpGet("{LibeGouv}/{LibeDele}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetByLibeGouvDele(string LibeGouv, string LibeDele)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeGouvDele(LibeGouv, LibeDele));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }

        [HttpGet("{LibeGouv}/{LibeDele}/{LibeComm}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetByLibeGouvDeleComm(string LibeGouv, string LibeDele, string LibeComm)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeGouvDeleComm(LibeGouv, LibeDele, LibeComm));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }

        [HttpGet("typesEtablissements")]
        public async Task<ActionResult<IEnumerable<NomenclatureTypeEtablissement>>> GetTypeEtablissement()
        {
            return await Task.FromResult(_IEtablissement.GetTypeEtabList());
        }
        
        [HttpGet("EtatsEtablissements")]
        public async Task<ActionResult<IEnumerable<NomenclatureEtatEtablissement>>> GetEtatEtablissement()
        {
            return await Task.FromResult(_IEtablissement.GetEtatEtabtList());
        }

       
        [HttpGet("gouvernorat")]
        public async Task<ActionResult<IEnumerable<NomenclatureGouvernorat>>> GetGouvernorat()
        {
            return await Task.FromResult(_IEtablissement.GetGouvList());
        }


        [HttpGet("delegation")]
        public async Task<ActionResult<IEnumerable<NomenclatureDelegation>>> GetDelegation()
        {
            return await Task.FromResult(_IEtablissement.GetDeleList());
        }

        [HttpGet("commune")]
        public async Task<ActionResult<IEnumerable<NomenclatureCommune>>> GetCommune()
        {
            return await Task.FromResult(_IEtablissement.GetCommList());
        }

        [HttpGet("NiveauEtude")]
        public async Task<ActionResult<IEnumerable<NomenclatureNiveauEtude>>> GetNiveauEtude()
        {
            return await Task.FromResult(_IEtablissement.GetNivEtdList());
        }

        [HttpGet("Diplomes")]
        public async Task<ActionResult<IEnumerable<NomenclatureDiplome>>> GetDiplomes()
        {
            return await Task.FromResult(_IEtablissement.GetDipList());
        }

        [HttpGet("SituationFamiliales")]
        public async Task<ActionResult<IEnumerable<NomenclatureSituationFamiliale>>> GetSituationFamiliales()
        {
            return await Task.FromResult(_IEtablissement.GetSitFList());
        }
    }
}
