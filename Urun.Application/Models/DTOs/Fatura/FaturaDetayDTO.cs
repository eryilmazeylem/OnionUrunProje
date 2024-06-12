using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.DTOs.Fatura
{
    public class FaturaDetayDTO
    {
        public int FaturaDetayID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }

    }
}
