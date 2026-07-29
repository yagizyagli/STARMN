using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult List()
        {
            var categoryList = _categoryService.GetAll();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            bool categorySave = _categoryService.Save(category);
            if (categorySave) 
            {
                return RedirectToAction("List");             
            }
            ViewBag.ErrorMessage = "Kategori eklenirken bir hata oluştu.";
            return View();
        } 
      
        public IActionResult Update(int id)
        {
            var categoryUpdateId=_categoryService.GetById(id);
            return View(categoryUpdateId);
        }
        
        [HttpPost]
        public IActionResult Update(Category category)
        {

            bool categoryUpdate = _categoryService.Update(category);
            if (categoryUpdate) 
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Kategori güncellenirken bir hata oluştu.";
            return View();
        }

        public IActionResult Delete(int id) 
        {
            var categoryDeleteId=_categoryService.GetById(id);
            return View(categoryDeleteId);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            bool categoryDelete = _categoryService.Delete(category.Id);
            if (categoryDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Kategori silinirken bir hata oluştu.";
            return View();
        }

        

        
    }
}
