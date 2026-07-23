using Microsoft.AspNetCore.Mvc;

namespace STARMN.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
