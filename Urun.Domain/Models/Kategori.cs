using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Enums;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Domain.Models
{
    public class Kategori : IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }


        public DateTime EklenmeTarihi { get ; set ; }
        public DateTime? DegismeTarihi { get ; set ; }
        public DateTime? SilmeTarihi   { get ; set ; }
        public KayitDurumu KayitDurumu { get; set; }

        public ICollection<UrunKategori>? KategoriUrunleri { get; set; }
    }
}
