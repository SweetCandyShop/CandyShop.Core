using System.Linq;

namespace CandyShop.Infrastructure.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Entities { get; }
        TEntity Insert(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);

        void ApplyChanges();
        void DiscardChanges();
    }
}
