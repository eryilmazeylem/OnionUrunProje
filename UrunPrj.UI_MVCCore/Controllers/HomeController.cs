using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UrunPrj.Application.Services.UrunKategoriService;
using UrunPrj.Application.Services.UrunService;
using UrunPrj.UI_MVCCore.Models;

namespace UrunPrj.UI_MVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUrunService _urunService;
        

        public HomeController(IUrunService urunService)
        {
            _urunService = urunService;
            
        }

        public async Task< IActionResult> Index()
        {

            return View(await _urunService.UrunListeleAsync());
        }

        public async Task<IActionResult >Detay(int id)
        {
          var urunDetayVM= await  _urunService.UrunBulAsync(id);
            return View(urunDetayVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
