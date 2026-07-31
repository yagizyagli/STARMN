using Microsoft.AspNetCore.Mvc;
using STARMN.Core.EntityDTOS;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        public BasketController(IBasketService basketService,IProductService productService,IUserService userService)
        {
            _basketService = basketService;
            _productService = productService;
            _userService = userService;
        }
        public IActionResult List(int userId)
        {
            var basketList=_basketService.SepetList(userId);
            return View(basketList);
        }
        public IActionResult Create()
        {
            ViewBag.Urunler = _productService.GetAll();
            ViewBag.Kullanicilar = _userService.GetAll();            
            return View();
        }
        [HttpPost]
        public IActionResult Create(SepetDto sepetDto)
        {
            var basketSave = _basketService.SepeteEkle(sepetDto);

            if (basketSave != null)
            {
                return RedirectToAction("List");
            }            
            ViewBag.ErrorMessage = "Sepete eklenirken bir hata oluştu.";
            return View(sepetDto);
        }        
        public IActionResult Update(int id)
        {
            ViewBag.Urunler = _productService.GetAll();
            ViewBag.Kullanicilar = _userService.GetAll();            
            var basketUpdateId = _basketService.SepeteIDIleGetir(id);
            return View(basketUpdateId);

        }
        [HttpPost]
        public IActionResult Update(SepetDto sepetDto)
        {
            var basketUpdate = _basketService.SepetGuncelle(sepetDto);
            if (basketUpdate != null)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sepet güncellenirken bir hata oluştu.";

            return View(sepetDto);

        }
        public IActionResult Delete(int id) 
        {
            ViewBag.Urunler = _productService.GetAll();
            ViewBag.Kullanicilar = _userService.GetAll();
            var basketDeleteId = _basketService.SepeteIDIleGetir(id);
            return View(basketDeleteId);
        }
        [HttpPost]
        public IActionResult Delete(SepetDto sepetDto)
        {
            var basketDelete = _basketService.SepetSil(sepetDto.Id);
            if (basketDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sepet silinirken bir hata oluştu.";

            return View(sepetDto);

        }


    }
}
