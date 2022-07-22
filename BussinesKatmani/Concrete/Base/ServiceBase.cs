using BussinesKatmani.Abstract.Base;
using EntityKatmani.Abstract;
using EntityKatmani.Extensions;
using Response;
using VeriErisimKatmani.Abstract.Base;

namespace BussinesKatmani.Concrete.Base
{
    public class ServiceBase<TEntity>:IServiceBase<TEntity>
        where TEntity : class,IEntity
    {
        protected IDalBase<TEntity> _dalBase;
        public ServiceBase(IDalBase<TEntity> DalBase)
        {
            _dalBase = DalBase;
        }

        public async Task<ObjectResponse<TEntity>> AddAsync(TEntity entity)
        {
            ObjectResponse<TEntity> result;

            try
            {
                if (entity.isEmpity())
                {
                    result = new ObjectResponse<TEntity>(
                        await _dalBase.AddAsync(entity)
                        );
                }
                else
                {
                    result = new ObjectResponse<TEntity>("Geçersiz veri");
                }
            }catch(Exception e)
            {
                result = new ObjectResponse<TEntity>("Ekleme işleminde hata oluştu.");
            }

            return result;
        }

        public async Task<ObjectResponse<object>> DeleteAsync(int id)
        {
            ObjectResponse<object> result;

            if(id > 0)
            {
                try
                {
                    var val = await _dalBase.DeleteAsync(id);
                    result = val ? new ObjectResponse<object>(val) : 
                        new ObjectResponse<object>("İlgili nesne silinemedi."); 
                }
                catch(Exception e)
                {
                    result = new ObjectResponse<object>("Silme işlemi sırasında hata oluştu");
                }
            }
            else
            {
                result = new ObjectResponse<object>("Geçersiz veri");
            }

            return result;
        }

        public async Task<ObjectResponse<TEntity>> GetAsync(int id)
        {
            ObjectResponse<TEntity> result;
            if (id > 0)
            {
                try
                {
                    var val = await _dalBase.GetAsync(p => p.Id == id);
                    result = val != null ? new ObjectResponse<TEntity>(val.FirstOrDefault()) :
                        new ObjectResponse<TEntity>("İlgili nesne bulunamadı.");
                }
                catch (Exception e)
                {
                    result = new ObjectResponse<TEntity>("İlgili nesne getirme esnasında hata oluştu");
                }
            }
            else
                result = new ObjectResponse<TEntity>("Geçersiz veri");
            return result;
        }

        public async Task<ObjectResponse<List<TEntity>>> GetAsync()
        {
            ObjectResponse<List<TEntity>> result;
            try
            {
                result = new ObjectResponse<List<TEntity>>(
                    await _dalBase.GetAsync()
                    );
            }
            catch (Exception e)
            {
                result = new ObjectResponse<List<TEntity>>("Nesneler getiriliken hata oluştu");
            }
            return result;
        }

        public async Task<ObjectResponse<TEntity>> UpdateAsync(TEntity entity)
        {
            ObjectResponse<TEntity> result;
            if (entity.isNotEmpity())
            {
                try
                {
                    result = new ObjectResponse<TEntity>(await _dalBase.UpdateAsync(entity));
                }catch(Exception e)
                {
                    result = new ObjectResponse<TEntity>("İlgili nesne güncellenirken hata oluştu");
                }
            }
            else
                result = new ObjectResponse<TEntity>("Geçersiz veri");
            return result;
        }
    }
}
