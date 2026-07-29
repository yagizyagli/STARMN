using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
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
            var orderList = _orderService.GetAll();
            return View(orderList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            var orderSave=_orderService.Save(order);
            if (orderSave!=null)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sipariş eklenirken bir hata oluştu";
            return View();
          
        }      
        public IActionResult Update(int id)
        {
            var orderUpdateId = _orderService.GetById(id);
            return View(orderUpdateId);
        }

        [HttpPost]
        public IActionResult Update(Order order)
        {
            var orderUpdate= _orderService.Update(order);
            if (orderUpdate != null)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sipariş güncellenirken bir hata oluştu";
            return View();


        }

        public IActionResult Delete(int id)
        {
            var orderDeleteId= _orderService.GetById(id);
            return View(orderDeleteId);

        }
        [HttpPost]
        public IActionResult Delete(Order order)
        {
            var orderDelete=_orderService.Delete(order.Id);
            if (orderDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sipariş silinirken bir hata oluştu";
            return View();
        }

    }
}
