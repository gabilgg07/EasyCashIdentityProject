using EasyCashIdentityProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ConfirmMailController : Controller
    {
        [HttpGet]
        public IActionResult Index(int id)
        {
            var email = TempData["Email"];
            ViewBag.Email = email+" elavesi ile";
            return View();
        }

        [HttpPost]
        public IActionResult Index(ConfirmMailViewModel confirmMailViewModel)
        {
            return View();
        }
    }
}
