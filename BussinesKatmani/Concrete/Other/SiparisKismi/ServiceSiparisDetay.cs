using BussinesKatmani.Abstract.Other.SiparisKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.SiparisKismi;
using VeriErisimKatmani.Abstract.Other.SiparisKismi;

namespace BussinesKatmani.Concrete.Other.SiparisKismi
{
    public class ServiceSiparisDetay : ServiceBase<SiparisDetay>, IServiceSiparisDetay
    {
        public ServiceSiparisDetay(IDalSiparisDetay DalBase) : base(DalBase)
        {
        }
    }
}
