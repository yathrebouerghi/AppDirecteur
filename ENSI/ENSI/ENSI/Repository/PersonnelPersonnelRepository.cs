using ENSI.Interface;
using ENSI.Models;
using NuGet.Protocol.Plugins;

namespace ENSI.Repository
{
    public class PersonnelPersonnelRepository : IPersonnel
    {
        readonly DbToufoulaProdContext _dbContext = new();

        public PersonnelPersonnelRepository(DbToufoulaProdContext dbContext)
        {
            _dbContext = dbContext;
        }

        public NomenclatureCorp getCorpByCode(string codeCorp)
        {
            var corp = _dbContext.NomenclatureCorps.FirstOrDefault(u => u.CodeCorp == codeCorp);

            return corp;
        }

        public NomenclatureFonction getFonctionByCode(string codeFonction)
        {
            var fonction = _dbContext.NomenclatureFonctions.FirstOrDefault(u => u.CodeFonc == codeFonction);

            return fonction;
        }

        public NomenclatureGenre getGenreByCode(string codeGenre)
        {
            var genre = _dbContext.NomenclatureGenres.FirstOrDefault(u => u.CodeGenr == codeGenre);

            return genre;
        }

        public NomenclatureGrade getGradeByCode(string codeGrade)
        {
            var grade = _dbContext.NomenclatureGrades.FirstOrDefault(u => u.CodeGrad == codeGrade);

            return grade;
        }

        public NomenclatureNiveauEtude getNiveauEtdByCode(string NivEtd)
        {
            var niveau = _dbContext.NomenclatureNiveauEtudes.FirstOrDefault(u => u.CodeNiveEtud == NivEtd);

            return niveau;
        }

        public PersonnelPersonnel GetPersonnelByidenUniq(string cin)
        {
            try
            {
                int anneeScolairePrecedente = 2022;
                var Personnel = _dbContext.PersonnelPersonnel.FirstOrDefault(u => u.NumeCin == cin && u.AnneScol == anneeScolairePrecedente);

                return Personnel;
            }
            catch
            {
                throw;
            }
        }

        public List<PersonnelPersonnel> GetPersonnelsByCodeEtabAsync(string codeEtab)
        {
            try
            {
                int anneeScolairePrecedente = 2022;
                List<PersonnelPersonnel> Personnels = _dbContext.PersonnelPersonnel.Where(e => e.CodeEtab == codeEtab && e.AnneScol == anneeScolairePrecedente).ToList();
                return Personnels;
            }
            catch
            {
                throw;
            }
        }

        public NomenclatureQualite getQualiteByCode(string codeQualite)
        {
            var qualite = _dbContext.NomenclatureQualites.FirstOrDefault(u => u.CodeQual == codeQualite);

            return qualite;
        }

        public NomenclatureSituationFamiliale getSitFByCode(string codeSit)
        {
            var situationFam = _dbContext.NomenclatureSituationFamiliales.FirstOrDefault(u => u.CodeSituFami == codeSit);

            return situationFam;
        }

        public NomenclatureSituationProfessionel getSitProdByCode(string codeSitP)
        {
            var situationPro = _dbContext.NomenclatureSituationProfessionels.FirstOrDefault(u => u.CodeSituProf == codeSitP);

            return situationPro;
        }

        private int ObtenirAnneeScolairePrecedente()
        {
            // Obtenez la date actuelle ou utilisez une date fournie si nécessaire
            DateTime dateActuelle = DateTime.Now;

            // Supposons que l'année scolaire commence en septembre (09)
            int moisDebutAnneeScolaire = 9; // Septembre
            int anneeActuelle = dateActuelle.Year;

            // Si la date actuelle est avant le mois de début de l'année scolaire,
            // considérez l'année précédente comme année scolaire précédente.
            if (dateActuelle.Month < moisDebutAnneeScolaire)
            {
                anneeActuelle--; // Soustrayez 1 à l'année actuelle
            }

            return anneeActuelle;
        }
    }
}
