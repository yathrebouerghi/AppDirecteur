using ENSI.Interface;
using ENSI.Models;
using Microsoft.EntityFrameworkCore;

namespace ENSI.Repository
{
    public class DirecteurRepository : IDirecteur
    {
        private readonly DbToufoulaProdContext _dbContext;
        public DirecteurRepository(DbToufoulaProdContext dbContext)
        {
            _dbContext = dbContext;
        }
        public SecuriteDirecteur GetById(int id)
        {
            var directeur = _dbContext.SecuriteDirecteurs.Find(id);
            if (directeur == null)
                throw new KeyNotFoundException("Directeur not found");
            return directeur;
        }

        public SecuriteDirecteur GetByLogin(string login)
        {
            var user = _dbContext.SecuriteDirecteurs.FirstOrDefault(u => u.Login == login);

            return user;
        }

        public void UpdatePWD(int id, SecuriteDirecteur model)
        {
            var directeur = GetById(id);
            if (model.Pwd != null)
            {
                directeur.Pwd = model.Pwd;
            }
                
                
            _dbContext.Entry(directeur).State = EntityState.Modified;

            _dbContext.SecuriteDirecteurs.Update(directeur);
            _dbContext.SaveChanges();

        }
        private bool DirecteurExists(int id)
        {
            return _dbContext.SecuriteDirecteurs.Any(e => e.Id == id);
        }
    }
}
