using BussinesKatmani.Abstract.Other.FirmaKismi;
using BussinesKatmani.Abstract.Other.KategoriKismi;
using BussinesKatmani.Abstract.Other.RolKismi;
using BussinesKatmani.Abstract.Other.SiparisKismi;
using BussinesKatmani.Abstract.Other.UrunKismi;
using BussinesKatmani.Abstract.Other.UserKismi;
using BussinesKatmani.Concrete.Other.FirmaKatmani;
using BussinesKatmani.Concrete.Other.KategoriKismi;
using BussinesKatmani.Concrete.Other.RolKismi;
using BussinesKatmani.Concrete.Other.SiparisKismi;
using BussinesKatmani.Concrete.Other.UrunKisimi;
using BussinesKatmani.Concrete.Other.UserKismi;
using VeriErisimKatmani.Other;

namespace BussinesKatmani.Other
{
    public class ServiceOlusturucu
    {
        #region Firma Kısmı
        public IServiceMarka Marka { get; }
        #endregion
        #region Kategori Kısmı
        public IServiceKategori Kategori { get; }
        #endregion
        #region Rol Kısmı
        public IServiceRol Rol { get; }
        #endregion
        #region Sipariş Kısmı
        public IServiceSiparis Siparis { get; }
        public IServiceSiparisDetay SiparisDetay { get; }
        #endregion
        #region Ürün Kısmı
        public IServiceUrun Urun { get; }
        public IServiceUrunOzellik UrunOzellik { get; }
        public IServiceUrunOzellikTip UrunOzellikTip { get; }
        public IServiceUrunYorum UrunYorum { get; }
        #endregion
        #region User Kısmı
        public IServiceUser User { get; }
        #endregion

        private ServiceOlusturucu()
        {
            #region Firma Kısmı
            this.Marka = new ServiceMarka(DalOlusturucu.olustur.Marka);
            #endregion
            #region Kategori Kısmı
            this.Kategori = new ServiceKategori(DalOlusturucu.olustur.Kategori);
            #endregion
            #region Rol Kısmı
            this.Rol = new ServiceRol(DalOlusturucu.olustur.Rol);
            #endregion
            #region Sipariş Kısmı
            this.Siparis = new ServiceSiparis(DalOlusturucu.olustur.Siparis);
            this.SiparisDetay = new ServiceSiparisDetay(DalOlusturucu.olustur.SiparisDetay);
            #endregion
            #region Ürün Kısmı
            this.Urun = new ServiceUrun(DalOlusturucu.olustur.Urun);
            this.UrunOzellik = new ServiceUrunOzellik(DalOlusturucu.olustur.UrunOzellik);
            this.UrunOzellikTip = new ServiceUrunOzellikTip(DalOlusturucu.olustur.UrunOzellikTip);
            this.UrunYorum = new ServiceUrunYorum(DalOlusturucu.olustur.UrunYorum);
            #endregion
            #region User Kısmı
            this.User = new ServiceUser(DalOlusturucu.olustur.User);
            #endregion
        }

        private static readonly Lazy<ServiceOlusturucu> lazy= new Lazy<ServiceOlusturucu>(
            () => new ServiceOlusturucu());

        public static ServiceOlusturucu Olustur
        {
            get { return lazy.Value; }
        }
    }
}
