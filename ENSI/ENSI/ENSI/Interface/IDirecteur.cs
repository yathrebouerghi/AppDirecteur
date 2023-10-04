using ENSI.Models;

namespace ENSI.Interface
{
    public interface IDirecteur
    {
        SecuriteDirecteur GetById(int id);
        SecuriteDirecteur GetByLogin(string login);
        void UpdatePWD(int id, SecuriteDirecteur model);
    }
}
