using Microsoft.AspNetCore.Mvc;
using STARMN.Core.EntityDTOS;
using STARMN.Service.Services.Interfaces;
using STARMN.Web.Models;
using System.Text.Json;

namespace STARMN.Web.Controllers
{
    public class ShopController : Controller
    {
        
        
            private readonly IProductService _productService;
            private readonly ICategoryService _categoryService;
            private readonly IBasketService _basketService;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public ShopController(IProductService productService, ICategoryService categoryService, IBasketService basketService, IHttpContextAccessor httpContextAccessor)
            {
                _productService = productService;
                _categoryService = categoryService;
                _basketService = basketService;
                _httpContextAccessor = httpContextAccessor;
            }
            public IActionResult Index(int id = 0)
            {
                var productList = _productService.GetAll();

                if (id > 0)
                {
                    productList = productList.Where(p => p.CategoryId == id).ToList();
                }
                var categoryList = _categoryService.GetAll();

                var productCategoryView = new ProductCategoryView
                {
                    ProductList = productList,
                    CategoryList = categoryList
                };
                return View(productCategoryView);
            }
            [HttpPost]
            public JsonResult SepeteEkle(int urunId, decimal urunFiyat)
            {
            try
            {
                SepetDto sepetDto = new SepetDto
                {
                    ProductId = urunId,
                    Fiyat = urunFiyat,
                    Adet = 1,
                    EkleynId = 1,
                    Adi = _productService.GetById(urunId).Adi
                };
                _basketService.SepeteEkle(sepetDto);

                return Json(new { success = true });
            }
                
              catch (Exception ex)
              {
                return Json(new { success = false, message = ex.Message });
              }

            }

            #region Cookie (Çerez) İşlemleri 

            /// <summary>
            /// Sepetteki ürümleri Cookie'ye ekler
            /// </summary>
            /// <param name="guncelSepetList"></param>
            public void UrunuCookieyeEkle(List<SepetDto> guncelSepetList)
            {
                var cookieyeOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(7),
                    HttpOnly = true,
                    Secure = true
                };

                var jsonString = JsonSerializer.Serialize(guncelSepetList);
                _httpContextAccessor.HttpContext.Response.Cookies.Append("MusteriSepeti", jsonString, cookieyeOptions);

            }


            public List<SepetDto> CookidekiUrunleriGetir()
            {
                var cookie = _httpContextAccessor.HttpContext.Request.Cookies["MusteriSepeti"];

                if (cookie == null)
                {
                    return new List<SepetDto>();
                }

                return JsonSerializer.Deserialize<List<SepetDto>>(cookie);

            #endregion
            }
        }
    }

