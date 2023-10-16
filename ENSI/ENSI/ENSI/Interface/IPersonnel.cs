using ENSI.Models;

namespace ENSI.Interface
{
    public interface IPersonnel
    {
        public List<PersonnelPersonnel> GetPersonnelsByCodeEtabAsync(string codeEtab);
        public PersonnelPersonnel GetPersonnelByidenUniq(string cin);

        public NomenclatureGenre getGenreByCode(string codeGenre);
        public NomenclatureNiveauEtude getNiveauEtdByCode(string NivEtd);
        public NomenclatureSituationFamiliale getSitFByCode(string codeSit);
        public NomenclatureGrade getGradeByCode(string codeGrade);
        public NomenclatureQualite getQualiteByCode(string codeQualite);
        public NomenclatureSituationProfessionel getSitProdByCode(string codeSitP);
        public NomenclatureFonction getFonctionByCode(string codeFonction);

        public NomenclatureCorp getCorpByCode(string codeCorp);
    }
}
