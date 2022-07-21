using EntityKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.UrunKismi;

namespace EntityKatmani.Concrete.Other.SiparisKismi
{
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
