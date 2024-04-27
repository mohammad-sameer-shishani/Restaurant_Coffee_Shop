using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Coffee_Shop.Controllers
{
    public class LoginAndRegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
