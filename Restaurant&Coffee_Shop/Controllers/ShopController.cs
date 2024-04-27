using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Coffee_Shop.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
