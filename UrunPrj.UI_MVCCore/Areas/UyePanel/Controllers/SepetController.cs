using Microsoft.AspNetCore.Mvc;
using UrunPrj.Application.Models.DTOs.Sepet;
using UrunPrj.Application.Services.SepetService;
using UrunPrj.Application.Services.UserService;

namespace UrunPrj.UI_MVCCore.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    public class SepetController : Controller
    {
        private readonly ISepetService _sepetService;
        private readonly IUserService _userservice;

        public SepetController(ISepetService sepetService, IUserService userservice)
        {
            _sepetService = sepetService;
            _userservice = userservice;
        }

        public async Task< IActionResult> Index()
        {
            //Uyenin sepetteki ürünleri listelenir.
            var urunler = await _sepetService.SepettekiUrunleriListeleAsync(_userservice.GetUserID(User));
            return View(urunler);
        }


        public async Task< IActionResult> SepeteEkle(int id)
        {
            SepeteEkleDTO sepeteEkleDTO=new SepeteEkleDTO();
            sepeteEkleDTO.UyeID = _userservice.GetUserID(User);
            sepeteEkleDTO.UrunID = id;
            await _sepetService.SepeteEkleAsync(sepeteEkleDTO);
            return NoContent();
            //return Content("Uyenin ID si= "+uyeID);

        }
    }
}
