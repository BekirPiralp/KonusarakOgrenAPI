using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UrunKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.SiparisKismi
{
    [Table("Siparisler")]
    public class Siparis : Entity
    {
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public double Tutar { get; set; }
        public string Musteri { get; set; }
    }
}
