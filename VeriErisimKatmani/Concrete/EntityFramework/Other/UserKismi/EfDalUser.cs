using EntityKatmani.Concrete.Other.UserKismi;
using VeriErisimKatmani.Abstract.Other.UserKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Other.UserKismi
{
    public class EfDalUser : EfDalBase<User,EfIdendityDbContext>,IDalUser
    {
    }
}
