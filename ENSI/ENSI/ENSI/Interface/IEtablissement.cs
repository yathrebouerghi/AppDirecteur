using ENSI.Models;

namespace ENSI.Interface
{
    public interface IEtablissement
    {
        public List<ViewEtablissement> GetEtablissements();

        public List<ViewEtablissement> GetEtablissementByLibeGouvAsync(string LibeGouv);
        public List<ViewEtablissement> GetEtablissementByLibeGouvDele(string LibeGouv, string LibDele);
        public List<ViewEtablissement> GetEtablissementByLibeGouvDeleComm(string LibeGouv, string LibDele, string LibComm);
    }
}
