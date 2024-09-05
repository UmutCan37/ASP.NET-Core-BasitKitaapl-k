using Kitaplık.DAL.Context;
using Kitaplık.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.Controllers
{
	public class UyeController : Controller
	{
		KitapContext context = new KitapContext();
		public IActionResult Index()
		{
			var values = context.Uyeler.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateUye()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateUye(Uye uye)
		{
			context.Uyeler.Add(uye);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteUye(int id)
		{
			var value = context.Uyeler.Find(id);
			context.Uyeler.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateUye(int id)
		{
			var value = context.Uyeler.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateUye(Uye uye)
		{
			context.Uyeler.Update(uye);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
