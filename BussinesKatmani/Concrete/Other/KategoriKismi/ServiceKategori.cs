using BussinesKatmani.Abstract.Other.KategoriKismi;
using BussinesKatmani.Concrete.Base;
using EntityKatmani.Concrete.Other.KategoriKismi;
using VeriErisimKatmani.Abstract.Other.KategoriKismi;

namespace BussinesKatmani.Concrete.Other.KategoriKismi
{
    public class ServiceKategori : ServiceBase<Kategori>, IServiceKategori
    {
        public ServiceKategori(IDalKategori DalBase) : base(DalBase)
        {
        }
    }
}
