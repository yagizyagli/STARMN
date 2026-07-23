using Microsoft.AspNetCore.Mvc;

namespace STARMN.Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
