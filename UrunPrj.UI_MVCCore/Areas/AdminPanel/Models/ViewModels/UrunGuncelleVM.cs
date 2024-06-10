namespace UrunPrj.UI_MVCCore.Areas.AdminPanel.Models.ViewModels
{
    public class UrunGuncelleVM
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public IFormFile? ResimAdi { get; set; }
        public int StokAdedi { get; set; }
    }
}
