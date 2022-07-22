using EntityKatmani.Concrete.Other.SiparisKismi;
using VeriErisimKatmani.Abstract.Other.SiparisKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Other.SiparisKismi
{
    public class EfDalSiparisDetay: EfDalBase<SiparisDetay,EfDbContext>,IDalSiparisDetay
    {
    }
}
