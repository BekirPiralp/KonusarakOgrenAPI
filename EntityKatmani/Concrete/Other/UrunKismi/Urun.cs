using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.FirmaKismi;
using EntityKatmani.Concrete.Other.KategoriKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    [Table("Urunler")]
    public class Urun : Entity
    {
        public Marka Marka { get; set; }
        public Kategori Kategori { get; set; }
        public string Name { get; set; }
        public double Fiyat { get; set; }
    }
}
