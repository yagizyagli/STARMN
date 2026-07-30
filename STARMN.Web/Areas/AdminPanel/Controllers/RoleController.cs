using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            
            _roleService = roleService;
        }
        public IActionResult List()
        {
            return View(_roleService.GetAll());
            

        }
        public IActionResult Create()         
        {
            return View();
        
        }
        [HttpPost]
        public IActionResult Create(Role role)
        {
            var roleSave = _roleService.Save(role);
            if (roleSave != null) 
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Rol eklenirken bir hata oluştu";
            return View();
        
        }
        public IActionResult Update(int id)
        {
            var roleUpdateId = _roleService.GetById(id);
            return View(roleUpdateId);

        }
        [HttpPost]
        public IActionResult Update(Role role)
        {
            var roleUpdate= _roleService.Update(role);
            if (roleUpdate != null)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Rol güncellenirken bir hata oluştu";
            return View();
        }
        public IActionResult Delete(int id) 
        {
            var roleDeleteId= _roleService.GetById(id);
            return View(roleDeleteId);

        }
        [HttpPost]
        public IActionResult Delete(Role role)
        {
            var roleDelete = _roleService.Delete(role.RoleId);
            if (roleDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Rol silinirken bir hata oluştu";
            return View();
        }
    }
}
