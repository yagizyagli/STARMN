using Microsoft.AspNetCore.Mvc;
using STARMN.Service.Services.Interfaces;
using STARMN.Web.Models;

namespace STARMN.Web.Controllers
{
    public class AnasayfaController : Controller
    {
        private readonly IProductService _productService;
        public AnasayfaController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var model = new ProductCategoryView
            {
                ProductList = _productService.GetAll()
            };

            return View(model);
        }
    }
}
