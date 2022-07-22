using EntityKatmani.Concrete.Other.FirmaKismi;
using VeriErisimKatmani.Abstract.Other.FirmaKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Other.FirmaKismi
{
    public class EfDalMarka : EfDalBase<Marka,EfDbContext>,IDalMarka
    {
    }
}
