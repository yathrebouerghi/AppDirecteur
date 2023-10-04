using ENSI.Interface;
using ENSI.Models;

namespace ENSI.Repository
{
    public class EtablissementRepository : IEtablissement
    {
        readonly DbToufoulaProdContext _dbContext = new();

        public EtablissementRepository(DbToufoulaProdContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<ViewEtablissement> GetEtablissementByLibeGouvDele(string LibeGouv, string LibDele)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissements.Where(e => e.LibeGouv == LibeGouv && e.LibeDele == LibDele).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementByLibeGouvAsync(string LibeGouv)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissements.Where(e => e.LibeGouv == LibeGouv).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissements()
        {

            try
            {
                return _dbContext.ViewEtablissements.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementByLibeGouvDeleComm(string LibeGouv, string LibDele, string LibComm)
        {

            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissements.Where(e => e.LibeGouv == LibeGouv && e.LibeDele == LibDele && e.LibeComm == LibComm).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureTypeEtablissement> GetTypeEtabList()
        {
            try
            {
                return _dbContext.NomenclatureTypeEtablissements.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureEtatEtablissement> GetEtatEtabtList()
        {
            try
            {
                return _dbContext.NomenclatureEtatEtablissements.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureGouvernorat> GetGouvList()
        {
            try
            {
                return _dbContext.NomenclatureGouvernorats.ToList();
            }
            catch
            {
                throw;
            };
        }

        public List<NomenclatureDelegation> GetDeleList()
        {
            try
            {
                return _dbContext.NomenclatureDelegations.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureCommune> GetCommList()
        {
            try
            {
                return _dbContext.NomenclatureCommunes.ToList();
            }
            catch
            {
                throw;
            };
        }

        public List<NomenclatureNiveauEtude> GetNivEtdList()
        {
            try
            {
                return _dbContext.NomenclatureNiveauEtudes.ToList();
            }
            catch
            {
                throw;
            };
        }

        public List<NomenclatureDiplome> GetDipList()
        {
            try
            {
                return _dbContext.NomenclatureDiplomes.ToList();
            }
            catch
            {
                throw;
            };
        }

        public List<NomenclatureSituationFamiliale> GetSitFList()
        {
            try
            {
                return _dbContext.NomenclatureSituationFamiliales.ToList();
            }
            catch
            {
                throw;
            };
        }
    }
}
