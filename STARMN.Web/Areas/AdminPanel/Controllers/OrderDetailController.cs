using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        public OrderDetailController(IOrderDetailService orderDetailService, IOrderService orderService, IProductService productService)
        {
            _orderDetailService = orderDetailService;
            _orderService = orderService;
            _productService = productService;

        }
        public IActionResult List()
        {
            return View(_orderDetailService.GetAll());

        }
        public IActionResult Create()
        {

            ViewBag.Siparisler = _orderService.GetAll();
            ViewBag.Urunler = _productService.GetAll();
            return View();

        }
        [HttpPost]
        public IActionResult Create(OrderDetail orderDetail)
        {
            var orderDetailSave = _orderDetailService.Save(orderDetail);
            if (orderDetailSave != null)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sipariş detayları eklenirken bir hata oluştu";
            return View();
        }

        public IActionResult Update(int id)
        {
            ViewBag.Siparisler = _orderService.GetAll();
            ViewBag.Urunler = _productService.GetAll();
            var orderDetailUpdateId = _orderDetailService.GetById(id);
            return View(orderDetailUpdateId);
        }
        [HttpPost]
        public IActionResult Update(OrderDetail orderDetail)
        {
            var orderDetailUpdate = _orderDetailService.Update(orderDetail);
            if (orderDetailUpdate != null)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sipariş detayları güncellenirken bir hata oluştu";
            return View();
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Siparisler = _orderService.GetAll();
            ViewBag.Urunler = _productService.GetAll();
            var orderDetailDeleteId = _orderDetailService.GetById(id);
            return View(orderDetailDeleteId);
        }
        [HttpPost]
        public IActionResult Delete(OrderDetail orderDetail)
        {
            var orderDetailDelete = _orderDetailService.Delete(orderDetail.Id);
            if (orderDetailDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Sipariş detayları silinirken bir hata oluştu";
            return View();
        }
    }
}
