using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Enums;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Domain.Models
{
    public class FaturaDetay:IEntity
    {
        public int FaturaDetayID { get; set; }
        public int FaturaID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        

        
        public DateTime EklenmeTarihi  { get ; set ; }
        public DateTime? DegismeTarihi { get ; set ; }
        public DateTime? SilmeTarihi   { get ; set ; }
        public KayitDurumu KayitDurumu { get ; set ; }
        public Fatura? Fatura { get; set; }
        public  Urun? Urun { get; set; }

    }
}
