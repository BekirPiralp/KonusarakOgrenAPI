using EntityKatmani.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityKatmani.Concrete.Other.FirmaKismi
{
    [Table("Markalar")]
    public class Marka :Entity
    {
        public string Name { get; set; }
        
        // normalde ayrılabilir lakin şuan için burada
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public string PostaKodu { get; set; }
        public string Tarif { get; set; }

        // iletisim bilgisi

        public string Email { get; set; }
        public string Tel { get; set; }


    }
}
