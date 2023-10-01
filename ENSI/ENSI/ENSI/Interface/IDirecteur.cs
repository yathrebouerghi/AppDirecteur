using ENSI.Models;

namespace ENSI.Interface
{
    public interface IDirecteur
    {
        SecuriteDirecteur GetById(int id);
        void UpdatePWD(int id, SecuriteDirecteur model);
    }
}
