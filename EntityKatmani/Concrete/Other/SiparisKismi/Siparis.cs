using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UrunKismi;
using EntityKatmani.Concrete.Other.UserKismi;

namespace EntityKatmani.Concrete.Other.SiparisKismi
{
    public class Siparis : Entity
    {
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public double Tutar { get; set; }
        public User Musteri { get; set; }
    }
}
