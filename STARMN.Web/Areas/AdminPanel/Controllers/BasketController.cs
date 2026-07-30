using Microsoft.AspNetCore.Mvc;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        


        public IActionResult Index()
        {
            return View();
        }
    }
}
