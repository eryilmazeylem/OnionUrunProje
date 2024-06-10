using Microsoft.AspNetCore.Mvc;

namespace UrunPrj.UI_MVCCore.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
