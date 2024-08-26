using Microsoft.AspNetCore.Mvc;

namespace Ogani.Contollers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Details(int Id)
		{
			return View();
		}

        public IActionResult Basket()
        {
            return View();
        }

		public IActionResult Checkout()
		{
			return View();
		}
	}
}
