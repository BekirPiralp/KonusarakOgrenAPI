using System.Linq.Expressions;

namespace VeriErisimKatmani.Abstract.Base
{
    public interface IDalBase<TEntity>
    {
        Task<List<TEntity>> GetAsync(Expression<Func<TEntity,bool>> filter=null);
        Task<bool> DeleteAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
