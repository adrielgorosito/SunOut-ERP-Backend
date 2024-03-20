using Microsoft.EntityFrameworkCore;

namespace SunOut_ERP_Backend.DataAccess.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected SunOutDbContext context;
        protected DbSet<T> DbSet;

        public GenericRepository(SunOutDbContext context)
        {
            this.context = context;
            DbSet = context.Set<T>();
        }

        public virtual async Task<T?> GetOne(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<T>?> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<int> Add(T t)
        {
            await DbSet.AddAsync(t);
            await context.SaveChangesAsync();

            return (int)context.Entry(t).Property("Id").CurrentValue!;
        }

        public virtual async Task Update(T t)
        {
            context.ChangeTracker.Clear();
            context.Update(t);
            await context.SaveChangesAsync();
        }

        public virtual async Task Delete(T t)
        {
            context.Remove(t);
            await context.SaveChangesAsync();
        }
    }
}
