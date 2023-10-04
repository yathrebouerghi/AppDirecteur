using ENSI.Models;

namespace ENSI.Interface
{
    public interface IEtablissement
    {
        public List<ViewEtablissement> GetEtablissements();

        public List<ViewEtablissement> GetEtablissementByLibeGouvAsync(string LibeGouv);
        public List<ViewEtablissement> GetEtablissementByLibeGouvDele(string LibeGouv, string LibDele);
        public List<ViewEtablissement> GetEtablissementByLibeGouvDeleComm(string LibeGouv, string LibDele, string LibComm);
        //type Etablissement
        public List<NomenclatureTypeEtablissement> GetTypeEtabList();
        //etat Etablissement
        public List<NomenclatureEtatEtablissement> GetEtatEtabtList();
        //liste deligation 
        public List<NomenclatureGouvernorat> GetGouvList();

        //liste governorat
        public List<NomenclatureDelegation> GetDeleList();
        //liste commune
        public List<NomenclatureCommune> GetCommList();

        //liste commune
        public List<NomenclatureNiveauEtude> GetNivEtdList();

        //liste commune
        public List<NomenclatureDiplome> GetDipList();
        //liste commune
        public List<NomenclatureSituationFamiliale> GetSitFList();
    }
}
