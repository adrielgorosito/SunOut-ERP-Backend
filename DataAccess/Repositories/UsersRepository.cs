using SunOut_ERP_Backend.DataAccess.Repositories.Generic;
using SunOut_ERP_Backend.Domain;
using System;

namespace SunOut_ERP_Backend.DataAccess.Repositories
{
    public class UsersRepository : GenericRepository<User>
    {
        public UsersRepository(SunOutDbContext context) : base(context) { }
    }
}
