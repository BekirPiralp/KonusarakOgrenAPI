using EntityKatmani.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    [Table("UrunOzellikler")]
    public class UrunOzellik : Entity
    {
        public Urun Urun { get; set; }
        public UrunOzellikTip OzellikTip { get; set; }
        public string Ozellik { get; set; }
        public double IndirimYuzdesi { get; set; }
    }
}
