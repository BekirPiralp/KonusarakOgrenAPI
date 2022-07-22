using EntityKatmani.Concrete.Other.FirmaKismi;
using EntityKatmani.Concrete.Other.KategoriKismi;
using EntityKatmani.Concrete.Other.SiparisKismi;
using EntityKatmani.Concrete.Other.UrunKismi;
using Library;
using Microsoft.EntityFrameworkCore;

namespace VeriErisimKatmani.Concrete.EntityFramework
{
    public class EfDbContext : DbContext
    {
        public EfDbContext():base()
        {

        }

        public EfDbContext(DbContextOptions options):base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: ConnectionStrings.get.DataConnection, opt => opt.EnableRetryOnFailure(maxRetryCount: 10));
            base.OnConfiguring(optionsBuilder);
        }

        #region Firma kısmı
        public DbSet<Marka> Markalar { get; set; }
        #endregion

        #region Kategori kısmı
        public DbSet<Kategori> Kategoriler { get; set; }
        #endregion

        #region Sipariş kısmı
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        #endregion

        #region Ürün kısmı
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<UrunOzellik> UrunOzellikler { get; set; }
        public DbSet<UrunOzellikTip> UrunOzellikTipler { get; set; }
        public DbSet<UrunYorum> UrunYorumlar { get; set; }
        #endregion
    }
}
