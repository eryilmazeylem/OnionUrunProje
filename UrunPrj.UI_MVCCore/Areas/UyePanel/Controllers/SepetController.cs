using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SepeteEkle(int id)
        {
            int uyeID = _userservice.GetUserID(User);
            return Content("Uyenin ID si= "+uyeID);
        }
    }
}
