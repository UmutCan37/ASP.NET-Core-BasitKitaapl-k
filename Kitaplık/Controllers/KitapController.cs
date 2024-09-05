using Kitaplık.DAL.Context;
using Kitaplık.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kitaplık.Controllers
{
	public class KitapController : Controller
	{
		KitapContext context = new KitapContext();
		public IActionResult Index()
		{
			var values = context.Kitaplar.Include(x=>x.Kategori).ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateKitap()
		{
			List<SelectListItem> deger=(from x in context.Kategoriler.ToList()
										select new SelectListItem
										{
											Text=x.KategoriAdi,
											Value=x.KategoriId.ToString()
										}).ToList();
			ViewBag.dgr1=deger;
			return View();
		}
		[HttpPost]
		public IActionResult CreateKitap(Kitap kitap)
		{
			context.Kitaplar.Add(kitap);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteKitap(int id)
		{
			var value = context.Kitaplar.Find(id);
			context.Kitaplar.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateKitap(int id)
		{
			List<SelectListItem> deger = (from x in context.Kategoriler.ToList()
										  select new SelectListItem
										  {
											  Text = x.KategoriAdi,
											  Value = x.KategoriId.ToString()
										  }).ToList();
			ViewBag.dgr1 = deger;
			var value = context.Kitaplar.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateKitap(Kitap kitap)
		{
			context.Kitaplar.Update(kitap);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = context.Kitaplar.Find(id);
			value.Durum = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = context.Kitaplar.Find(id);
			value.Durum = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}