using Microsoft.AspNetCore.Mvc;
using STARMN.Service.Services.Interfaces;


namespace STARMN.Web.Controllers
{
    public class SepetController : Controller
    {               
        public IActionResult Index()
        {
           return View();
        }
    }
    
}
