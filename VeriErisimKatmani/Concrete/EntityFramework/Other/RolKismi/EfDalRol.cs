using EntityKatmani.Concrete.Other.RolKismi;
using VeriErisimKatmani.Abstract.Other.RolKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Other.RolKismi
{
    public class EfDalRol : EfDalBase<Rol,EfIdendityDbContext>,IDalRol
    {
    }
}
