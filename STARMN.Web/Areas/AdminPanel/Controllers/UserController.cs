using Microsoft.AspNetCore.Mvc;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
