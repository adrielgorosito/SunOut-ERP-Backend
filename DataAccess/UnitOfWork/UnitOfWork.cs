using SunOut_ERP_Backend.DataAccess.Repositories;

namespace SunOut_ERP_Backend.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private SunOutDbContext context;

        public UsersRepository UserRepository { get; set; }

        public UnitOfWork(SunOutDbContext context)
        {
            this.context = context;
            this.UserRepository = new UsersRepository(context);
        }

        public void SaveChangesAsync()
        {
            this.context.SaveChangesAsync();
        }
    }
}
