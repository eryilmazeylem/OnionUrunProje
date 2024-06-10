using Microsoft.AspNetCore.Mvc;

namespace UrunPrj.UI_MVCCore.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
