using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
using STARMN.Service.Services;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult List()
        {
            var orderlist = _orderService.GetAll();
            return View(orderlist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            var orderSave=_orderService.Save(order);         
            return RedirectToAction("List");
          
        }


        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Update(Order order)
        {
             _orderService.Update(order);           
             return RedirectToAction("List");
            
            
        }

        public IActionResult Delete()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _orderService.Delete(id);
            return RedirectToAction("List");
        }

    }
}
