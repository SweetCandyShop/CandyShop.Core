using CandyShop.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CandyShop.Infrastructure.Repositories
{
    class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        private readonly CandyShopDbContext context;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(CandyShopDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Entities => dbSet;

        public TEntity Insert(TEntity entity)
        {
            return dbSet.Add(entity).Entity;
        }

        public TEntity Delete(TEntity entity)
        {
            return dbSet.Remove(entity).Entity;
        }

        public TEntity Update(TEntity entity)
        {
            return dbSet.Update(entity).Entity;
        }

        public void ApplyChanges()
        {
            context.SaveChanges();
        }

        public void DiscardChanges()
        {
            foreach (var entry in context.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

    }
}
