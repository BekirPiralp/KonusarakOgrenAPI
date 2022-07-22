using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UserKismi;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    public class UrunYorum : Entity
    {
        public Urun Urun { get; set; }
        public string MusteriId { get; set; }
        public string Yorum { get; set; }
    }
}
