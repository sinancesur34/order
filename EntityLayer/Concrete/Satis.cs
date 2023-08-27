using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Satis
    {
        [Key]
        public int SatisID { get; set; }

        // Satış ile Müşteri arasında bir ilişki
        public string MusteriAdi { get; set; }

        public string MusteriSoyadi { get; set; }

        public DateTime Tarih { get; set; }


        //    // Satış ile Ür arasında bir ilişki

        public int UrunID { get; set; }
        public virtual Urun Urun { get; set; }

      
    }
}
