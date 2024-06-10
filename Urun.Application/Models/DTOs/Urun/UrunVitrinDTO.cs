using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.DTOs.Urun
{
    //Açılış sayfasında ürünleri göstermek için...
    public class UrunVitrinDTO
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public string ResimAdi { get; set; }
        
    }
}
