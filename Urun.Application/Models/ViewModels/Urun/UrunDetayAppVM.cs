using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;

namespace UrunPrj.Application.Models.ViewModels.Urun
{
    public class UrunDetayAppVM
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public string ResimAdi { get; set; }
        public int StokAdedi { get; set; }

        //UrunKategori tablosundan gelecek...
        public IEnumerable<KategoriDTO>? UrununKategorileri { get; set; }

     
    }
}
