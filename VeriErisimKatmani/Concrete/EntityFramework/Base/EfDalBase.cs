using EntityKatmani.Abstract;
using EntityKatmani.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VeriErisimKatmani.Abstract.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Base
{
    public class EfDalBase<TEntity, TContext> : IDalBase<TEntity>
        where TEntity : class,IEntity
        where TContext : DbContext,new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            TEntity result = null;
            if (entity.isEmpity())
            {
                using (TContext context = new TContext())
                {
                    context.Entry<TEntity>(entity).State = EntityState.Added;
                    int response=await context.SaveChangesAsync();

                    if (response > 0 && entity.isNotEmpity())
                        result = entity;
                }
            }
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = false;
            if(id > 0)
            {
                TEntity entity = (await GetAsync(p => p.Id == id)).FirstOrDefault();
                if (entity.isNotNull())
                {
                    using(TContext context = new TContext())
                    {
                        context.Entry(entity).State = EntityState.Deleted;
                        int response=await context.SaveChangesAsync();
                        if(response >0)
                            result = true;
                    }
                }
            }
            return result;
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            List<TEntity> result;
            using (TContext context = new TContext())
            {

                result = filter == null ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
            return result;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            TEntity result = null;
            if(entity.isNotEmpity())
            {
                using(TContext context = new TContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    int response=await context.SaveChangesAsync();
                    if (response > 0)
                        result = entity;                    
                }
            }
            return result;
        }
    }
}
