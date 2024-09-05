using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
