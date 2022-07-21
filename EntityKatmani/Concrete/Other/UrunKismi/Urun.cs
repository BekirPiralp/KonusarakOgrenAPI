using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.FirmaKismi;
using EntityKatmani.Concrete.Other.KategoriKismi;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    public class Urun : Entity
    {
        public Marka Marka { get; set; }
        public Kategori Kategori { get; set; }
        public string Name { get; set; }
        public double Fiyat { get; set; }
    }
}
