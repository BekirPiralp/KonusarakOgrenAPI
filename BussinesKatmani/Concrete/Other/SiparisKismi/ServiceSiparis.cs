using BussinesKatmani.Abstract.Other.SiparisKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.SiparisKismi;
using VeriErisimKatmani.Abstract.Other.SiparisKismi;

namespace BussinesKatmani.Concrete.Other.SiparisKismi
{
    public class ServiceSiparis : ServiceBase<Siparis>, IServiceSiparis
    {
        public ServiceSiparis(IDalSiparis DalBase) : base(DalBase)
        {
        }
    }
}
