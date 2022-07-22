using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UrunKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.SiparisKismi
{
    [Table("SiparisDetaylar")]
    public class SiparisDetay :Entity
    {
        /**
         * İlgili siparişin içerisindeki ürünün tipi farklı olmak kaydıyla özellikleri olacak
         * ve var ise ve indirimli ise
         * sipariş detay daki tutar güncellenecek
         */
        public Siparis Siparis { get; set; }
        public UrunOzellik UrunOzellik { get; set; }
    }
}
