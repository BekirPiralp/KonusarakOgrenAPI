using EntityKatmani.Abstract;
using Response;

namespace BussinesKatmani.Abstract.Base
{
    public interface IServiceBase<TEntity>
        where TEntity : class,IEntity
    {
        Task<ObjectResponse<TEntity>> GetAsync(int id);
        Task<ObjectResponse<List<TEntity>>> GetAsync();
        //boll değer dönderir
        Task<ObjectResponse<object>> DeleteAsync(int id);
        Task<ObjectResponse<TEntity>> AddAsync(TEntity entity);
        Task<ObjectResponse<TEntity>> UpdateAsync(TEntity entity);

    }
}
