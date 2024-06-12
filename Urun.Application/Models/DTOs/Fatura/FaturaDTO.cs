using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.DTOs.Fatura
{
    public class FaturaDTO
    {
        public int UyeID { get; set; }
        public DateTime FaturaKesimTarihi { get; set; }=DateTime.Now;
        public decimal ToplamFaturaTutari { get; set; }
    }
}
