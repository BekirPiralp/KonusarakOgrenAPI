using EntityKatmani.Concrete.Other.KategoriKismi;
using VeriErisimKatmani.Abstract.Other.KategoriKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Base;

namespace VeriErisimKatmani.Concrete.EntityFramework.Other.KategoriKismi
{
    public class EfDalKategori : EfDalBase<Kategori, EfDbContext>,IDalKategori
    {
    }
}
