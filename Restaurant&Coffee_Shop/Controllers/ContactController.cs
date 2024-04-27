using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Coffee_Shop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
