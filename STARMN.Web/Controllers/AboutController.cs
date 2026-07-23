using Microsoft.AspNetCore.Mvc;

namespace STARMN.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
