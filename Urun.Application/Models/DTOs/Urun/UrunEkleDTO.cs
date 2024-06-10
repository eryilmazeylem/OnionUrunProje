using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.DTOs.Urun
{
    public class UrunEkleDTO
    {
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public string ResimAdi { get; set; }
        public int StokAdedi { get; set; }
        public IEnumerable<int> SecilenKategoriler { get; set; }

    }
}
