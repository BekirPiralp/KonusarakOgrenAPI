using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UserKismi;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    public class UrunYorum : Entity
    {
        public Urun Urun { get; set; }
        public User Musteri { get; set; }
        public string Yorum { get; set; }
    }
}
