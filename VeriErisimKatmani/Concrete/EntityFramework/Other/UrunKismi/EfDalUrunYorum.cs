using EntityKatmani.Concrete.Other.UrunKismi;
using VeriErisimKatmani.Abstract.Other.UrunKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Other.UrunKismi
{
    public class EfDalUrunYorum : EfDalBase<UrunYorum, EfDbContext>, IDalUrunYorum
    {
    }
}
