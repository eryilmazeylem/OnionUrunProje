using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UrunPrj.Application.Models.DTOs.Urun;
using UrunPrj.Application.Services.KategoriService;
using UrunPrj.Application.Services.UrunKategoriService;
using UrunPrj.Application.Services.UrunService;
using UrunPrj.UI_MVCCore.Areas.AdminPanel.Models.ViewModels;

namespace UrunPrj.UI_MVCCore.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class UrunController : Controller
    {
        //Hangi Servisler tanımlanmalı
        //Urun,Kategori,Urunkategori

        private readonly IKategoriService _kategoriService;
        private readonly IUrunService _urunService;
      

        private readonly IMapper _mapper;

        public UrunController(IKategoriService kategoriService, IUrunService urunService, IMapper mapper)
        {
            _kategoriService = kategoriService;
            _urunService = urunService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UrunEkle()
        {
            UrunEkleVM urun=new UrunEkleVM();
            urun.Kategoriler = await _kategoriService.TumKategorilerAsync();
            return View(urun);
        }

        [HttpPost]  
        public async Task<IActionResult> UrunEkle(UrunEkleVM urun, int[] secilenKategoriler)
        {
            #region 
            //string str = "";
            //foreach(int s in urun.SecilenKategoriler)
            //    str += s+ " ";
            #endregion

            //Gelen Modeli kontrol et...(IsValid)
            //IsValid ise;
            //Resim dosyası var ise;kopyala...(GUID)
            //DTO olustur..
            //Bir ust katmana gönder...

            if (ModelState.IsValid) 
            {
                string strPath = "";
                string strFileName = "bosUrun.jpg";

                if (urun.ResimAdi != null)
                {
                    Guid guid = Guid.NewGuid();
                    strFileName = guid.ToString() + "_" + urun.ResimAdi.FileName;
                    strPath = "wwwroot/UrunResimleri/" + strFileName;
                    FileStream fs = new FileStream(strPath, FileMode.Create);
                    await urun.ResimAdi.CopyToAsync(fs);
                    fs.Close();
                }

                UrunEkleDTO urunEkleDTO = new UrunEkleDTO();
                urunEkleDTO.UrunAdi=urun.UrunAdi;
                urunEkleDTO.BirimFiyat = urun.BirimFiyat;
                urunEkleDTO.ResimAdi = strFileName;
                urunEkleDTO.StokAdedi=urun.StokAdedi;
                urunEkleDTO.SecilenKategoriler = secilenKategoriler;

              await  _urunService.UrunEkleAsync(urunEkleDTO);
                return RedirectToAction("Index");
            }

            return View(urun);
        }
    }
}
