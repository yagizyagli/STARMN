using Microsoft.AspNetCore.Mvc;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web.Areas.AdminPanel.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        public UserController(IUserService userService,IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }
        public IActionResult List()
        {
           return View(_userService.GetAll());
        }
        public IActionResult Create()
        {
            ViewBag.Roller = _roleService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            var userSave = _userService.Save(user);
            if (userSave != null) 
            {
                return RedirectToAction("List");            
            }
            ViewBag.ErrorMessage = "Kullanıcı eklenirken bir hata oluştu";
            return View();
        }
        public IActionResult Update(int id)
        {
            ViewBag.Roller = _roleService.GetAll();
            var userUpdateId=_userService.GetById(id); 
            return View(userUpdateId);
        }
        [HttpPost]
        public IActionResult Update(User user)
        { 
            var userUpdate= _userService.Update(user);
            if (userUpdate != null) 
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Kullanıcı güncellenirken bir hata oluştu";
            return View();
        }
        public IActionResult Delete(int id) 
        {
            ViewBag.Roller = _roleService.GetAll();
            var userDeleteId = _userService.GetById(id);
            return View(userDeleteId);
        }
        [HttpPost]
        public IActionResult Delete(User user)
        {
            var userDelete = _userService.Delete(user.Id);
            if (userDelete)
            {
                return RedirectToAction("List");
            }
            ViewBag.ErrorMessage = "Kullanıcı silinirken bir hata oluştu";
            return View();
        }
    }
}
