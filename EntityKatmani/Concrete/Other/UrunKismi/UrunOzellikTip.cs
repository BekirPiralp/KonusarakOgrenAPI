using EntityKatmani.Concrete.Base;

namespace EntityKatmani.Concrete.Other.UrunKismi
{
    public class UrunOzellikTip :Entity
    {
        /**
         * Örnek olarak bir ününün aynı anda birçok özelliği olmaktadır.
         * Bu özellikler aynı anda 1 üründe bulunuyor olabilir.
         * Örnek olarak bir kıyafetin boyu L olsun, rengi kırmızı, kesimi sport olsun
         * burada da gözüktüğü gibi çok özelliği var ve bu özelliklerin tipleri farklı
         *  biri boy, biri kesim, biri renk vs. yani bir ürün farklı tiplerde çoklu özelliğe
         *  sahip olabiliryor
         */
        string Tip { get; set; }
    }
}
