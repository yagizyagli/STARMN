using Microsoft.AspNetCore.Mvc;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        


        public IActionResult Index()
        {
            return View();
        }
    }
}
