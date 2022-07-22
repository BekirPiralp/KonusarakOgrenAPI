using BussinesKatmani.Abstract.Other.FirmaKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.FirmaKismi;
using VeriErisimKatmani.Abstract.Other.FirmaKismi;

namespace BussinesKatmani.Concrete.Other.FirmaKatmani
{
    public class ServiceMarka : ServiceBase<Marka>, IServiceMarka
    {
        public ServiceMarka(IDalMarka DalBase) : base(DalBase)
        {
        }
    }
}
