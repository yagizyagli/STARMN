using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult List()
        {
            return View(_productService.GetAll());
        }

        public IActionResult Create()
        {
            ViewBag.Kategoriler = _categoryService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.Save(product);
            return RedirectToAction("List");
        }

        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("List");
        }


    }
}
