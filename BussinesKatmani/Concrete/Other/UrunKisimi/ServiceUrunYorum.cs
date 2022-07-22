using BussinesKatmani.Abstract.Other.UrunKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UrunKismi;
using VeriErisimKatmani.Abstract.Other.UrunKismi;

namespace BussinesKatmani.Concrete.Other.UrunKisimi
{
    public class ServiceUrunYorum : ServiceBase<UrunYorum>, IServiceUrunYorum
    {
        public ServiceUrunYorum(IDalUrunYorum DalBase) : base(DalBase)
        {
        }
    }
}
