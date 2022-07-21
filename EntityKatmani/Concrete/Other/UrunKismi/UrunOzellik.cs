using EntityKatmani.Concrete.Base;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    public class UrunOzellik : Entity
    {
        public Urun Urun { get; set; }
        public UrunOzellikTip OzellikTip { get; set; }
        public string Ozellik { get; set; }
        public double IndirimYuzdesi { get; set; }
    }
}
