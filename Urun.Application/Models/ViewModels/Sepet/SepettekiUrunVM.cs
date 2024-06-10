using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.ViewModels.Sepet
{
    public class SepettekiUrunVM
    {
        public int SepetID { get; set; }
        public int UrunID { get; set; }
        public int UyeID { get; set; }
        public int Adet { get; set; }
        public string UrunAdi { get; set; }
        public int StoktakiUrunAdedi { get; set; }
        public decimal BirimFiyat { get; set; }

    }
}
