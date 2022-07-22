using EntityKatmani.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    [Table("UrunYorumlar")]
    public class UrunYorum : Entity
    {
        public Urun Urun { get; set; }
        public string MusteriId { get; set; }
        public string Yorum { get; set; }
    }
}
