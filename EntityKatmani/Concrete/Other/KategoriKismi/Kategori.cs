using EntityKatmani.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.KategoriKismi
{
    [Table("Kategoriler")]
    public class Kategori : Entity
    {
        public string Name { get; set;}
    }
}
