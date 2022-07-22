using BussinesKatmani.Abstract.Other.UserKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UserKismi;
using VeriErisimKatmani.Abstract.Other.UserKismi;

namespace BussinesKatmani.Concrete.Other.UserKismi
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        public ServiceUser(IDalUser DalBase) : base(DalBase)
        {
        }
    }
}
