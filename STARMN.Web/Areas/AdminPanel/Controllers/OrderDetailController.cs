using Microsoft.AspNetCore.Mvc;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService= orderDetailService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
