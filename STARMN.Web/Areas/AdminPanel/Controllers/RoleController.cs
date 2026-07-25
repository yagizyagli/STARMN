using Microsoft.AspNetCore.Mvc;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
