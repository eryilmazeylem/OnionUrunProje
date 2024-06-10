using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Enums;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Domain.Models
{
    public class UrunKategori:IEntity
    {
        public int UrunKategoriID { get; set; }
        public int UrunID { get; set; }
        public int KategoriID { get; set; }

       
        public DateTime EklenmeTarihi  { get ; set ; }
        public DateTime? DegismeTarihi { get ; set ; }
        public DateTime? SilmeTarihi   { get ; set ; }
        public KayitDurumu KayitDurumu { get ; set ; }

        public Urun? Urun { get; set; }
        public Kategori? Kategori { get; set; }
    }
}
