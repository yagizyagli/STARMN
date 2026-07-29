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
            ViewBag.Kategoriler=_categoryService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var productSave=_productService.Save(product);
            if (productSave != null) 
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Ürün eklenirken bir hata oluştu.";
            return View();
            
        }       

        public IActionResult Update(int id)
        {
            ViewBag.Kategoriler=_categoryService.GetAll();
            var productUpdateId = _productService.GetById(id);
            return View(productUpdateId);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            var productUpdate= _productService.Update(product);
            if (productUpdate != null) 
            {
                return RedirectToAction("List");
            
            }
            ViewBag.ErrorMessage = "Ürün güncellenirken bir hata oluştu.";
            return View();

        }

        public IActionResult Delete(int id)
        {
            ViewBag.Kategoriler=_categoryService.GetAll();
            var productDeleteId= _productService.GetById(id);
            return View(productDeleteId);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            var productDelete=_productService.Delete(product.Id);
            if (productDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Ürün silinirken bir hata oluştu.";
            return View();
        }



    }
}
