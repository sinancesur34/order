﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }

        [StringLength(1000)]
        public string UrunAd { get; set; }

        //[StringLength(100)]
        //public string UrunKategori { get; set; }

        public decimal Fiyat { get; set; }

       
        //// Ürün ile Satış arasında bir ilişki
        public virtual ICollection<Satis> Satislar { get; set; }
    }
}