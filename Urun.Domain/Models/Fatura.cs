using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Enums;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Domain.Models
{
    public class Fatura:IEntity
    {
        public int FaturaID { get; set; }
        public int UyeID { get; set; }
        public DateTime FaturaKesimTarihi { get; set; }
        public decimal ToplamFaturaTutari { get; set; }
      
       
        public DateTime EklenmeTarihi  { get ; set ; }
        public DateTime? DegismeTarihi { get ; set ; }
        public DateTime? SilmeTarihi   { get ; set ; }
        public KayitDurumu KayitDurumu { get ; set ; }

        public Uye Uye { get; set; }
        public ICollection<FaturaDetay>? FaturaDetayları { get; set; }

    }
}
