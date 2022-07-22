using VeriErisimKatmani.Abstract.Other.FirmaKismi;
using VeriErisimKatmani.Abstract.Other.KategoriKismi;
using VeriErisimKatmani.Abstract.Other.RolKismi;
using VeriErisimKatmani.Abstract.Other.SiparisKismi;
using VeriErisimKatmani.Abstract.Other.UrunKismi;
using VeriErisimKatmani.Abstract.Other.UserKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Other.FirmaKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Other.KategoriKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Other.RolKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Other.SiparisKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Other.UrunKismi;
using VeriErisimKatmani.Concrete.EntityFramework.Other.UserKismi;

namespace VeriErisimKatmani.Other
{
    public class DalOlusturucu
    {
        #region Firma Kısmı
        public IDalMarka Marka { get; }
        #endregion
        #region Kategori Kısmı
        public IDalKategori Kategori { get; }
        #endregion
        #region Rol Kısmı
        public IDalRol Rol { get; }
        #endregion
        #region Sipariş Kısmı
        public IDalSiparis Siparis { get; }
        public IDalSiparisDetay SiparisDetay { get; }
        #endregion
        #region Ürün Kısmı
        public IDalUrun Urun { get; }
        public IDalUrunOzellik UrunOzellik { get; }
        public IDalUrunOzellikTip UrunOzellikTip { get; }
        public IDalUrunYorum UrunYorum { get; }
        #endregion
        #region User Kısmı
        public IDalUser User { get; }
        #endregion

        private DalOlusturucu()
        {
            #region Firma Kısmı
            this.Marka = new EfDalMarka();
            #endregion
            #region Kategori Kısmı
            this.Kategori = new EfDalKategori();
            #endregion
            #region Rol Kısmı
            this.Rol = new EfDalRol();
            #endregion
            #region Sipariş Kısmı
            this.Siparis = new EfDalSiparis();
            this.SiparisDetay =new EfDalSiparisDetay();
            #endregion
            #region Ürün Kısmı
            this.Urun = new EfDalUrun();
            this.UrunOzellik = new EfDalUrunOzellik();
            this.UrunOzellikTip = new EfDalUrunOzellikTip();
            this.UrunYorum = new EfDalUrunYorum();
            #endregion
            #region User Kısmı
            this.User = new EfDalUser();
            #endregion
        }

        private static readonly Lazy<DalOlusturucu> lazy = 
            new Lazy<DalOlusturucu>(()=> new DalOlusturucu());

        public static DalOlusturucu olustur
        {
            get { return lazy.Value; }
        }
    }
}
