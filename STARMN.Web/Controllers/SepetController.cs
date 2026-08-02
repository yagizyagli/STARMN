using Microsoft.AspNetCore.Mvc;
using STARMN.Core.EntityDTOS;
using STARMN.Service.Services.Interfaces;


namespace STARMN.Web.Controllers
{
    public class SepetController : Controller
    {      
        private readonly IBasketService _basketService;

        public SepetController(IBasketService basketService)
        {
            _basketService = basketService;
        }
        public IActionResult Index(int id)
        {
            var sepetList = _basketService.SepetList(id);
            return View(sepetList);
        }
        
    }
    
}
