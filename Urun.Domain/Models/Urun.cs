using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Enums;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Domain.Models
{
    public class Urun:IEntity
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public string ResimAdi { get; set; } = "bosUrun.jpg";
        public int StokAdedi { get; set; }
       

       
        public DateTime EklenmeTarihi { get; set ; }
        public DateTime? DegismeTarihi { get; set ; }
        public DateTime? SilmeTarihi   { get; set ; }
        public KayitDurumu KayitDurumu { get; set; }
        public ICollection<UrunKategori>? UrunKategorileri { get; set; }

        public ICollection<FaturaDetay>? FaturaDetaylari { get; set; }

        public ICollection<Sepet>? SepettekiUrunler { get; set; } 
    }
}
