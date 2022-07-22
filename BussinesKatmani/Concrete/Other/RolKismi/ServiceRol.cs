using BussinesKatmani.Abstract.Other.RolKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.RolKismi;
using VeriErisimKatmani.Abstract.Other.RolKismi;

namespace BussinesKatmani.Concrete.Other.RolKismi
{
    public class ServiceRol : ServiceBase<Rol>, IServiceRol
    {
        public ServiceRol(IDalRol DalBase) : base(DalBase)
        {
        }
    }
}
