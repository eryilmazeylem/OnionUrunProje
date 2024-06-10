using UrunPrj.Application.Models.DTOs.Kategori;

namespace UrunPrj.UI_MVCCore.Areas.AdminPanel.Models.ViewModels
{
    public class UrunEkleVM
    {
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public IFormFile? ResimAdi { get; set; }
        public int StokAdedi { get; set; }
        public IEnumerable<KategoriDTO>? Kategoriler { get; set; }

        //public IEnumerable<int> SecilenKategoriler { get; set; }
    }
}
