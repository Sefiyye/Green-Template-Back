using Microsoft.AspNetCore.Mvc;

namespace Green_Template_Back.Areas.GreenTemplateAdmin.Controllers
{
    [Area("GreenTemplateAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
