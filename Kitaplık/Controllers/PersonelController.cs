using Kitaplık.DAL.Context;
using Kitaplık.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.Controllers
{
	public class PersonelController : Controller
	{
		KitapContext context = new KitapContext();
		public IActionResult Index()
		{
			var values = context.Personeller.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreatePersonel()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreatePersonel(Personel personel)
		{
			context.Personeller.Add(personel);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeletePersonel(int id)
		{
			var value = context.Personeller.Find(id);
			context.Personeller.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdatePersonel(int id)
		{
			var value = context.Personeller.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdatePersonel(Personel personel)
		{
			context.Personeller.Update(personel);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
