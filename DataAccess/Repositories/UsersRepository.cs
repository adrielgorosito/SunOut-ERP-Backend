using Microsoft.EntityFrameworkCore;
using SunOut_ERP_Backend.DataAccess.Repositories.Generic;
using SunOut_ERP_Backend.Domain;

namespace SunOut_ERP_Backend.DataAccess.Repositories
{
    public class UsersRepository : GenericRepository<User>
    {
        public UsersRepository(SunOutDbContext context) : base(context) { }

        public async Task<User?> GetOneByUsername(string username)
        {
            return await DbSet.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}
