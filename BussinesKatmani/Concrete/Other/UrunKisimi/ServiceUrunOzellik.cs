using BussinesKatmani.Abstract.Other.UrunKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UrunKismi;
using VeriErisimKatmani.Abstract.Other.UrunKismi;

namespace BussinesKatmani.Concrete.Other.UrunKisimi
{
    public class ServiceUrunOzellik : ServiceBase<UrunOzellik>, IServiceUrunOzellik
    {
        public ServiceUrunOzellik(IDalUrunOzellik DalBase) : base(DalBase)
        {
        }
    }
}
