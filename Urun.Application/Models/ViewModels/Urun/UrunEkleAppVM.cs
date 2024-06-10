using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;
using UrunPrj.Infrastructure.Repositories.Concrete;

namespace UrunPrj.Application.Models.ViewModels.Urun
{
    public class UrunEkleAppVM
    {
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public string ResimAdi { get; set; }
        public int StokAdedi { get; set; }

        //UI tarafında Selectlist olacak
        public IEnumerable<KategoriDTO> Kategoriler { get; set; }


        //public IEnumerable<KategoriDTO> UrununKategorileri { get; set; } bakılacak!!!
    }
}
