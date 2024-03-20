using SunOut_ERP_Backend.DataAccess.Repositories;

namespace SunOut_ERP_Backend.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        public UsersRepository UserRepository { get; }

        void SaveChangesAsync();
    }
}
