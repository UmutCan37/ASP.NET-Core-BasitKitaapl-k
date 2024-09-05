using Kitaplık.DAL.Context;
using Kitaplık.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kitaplık.Controllers
{
	public class OduncIslemController : Controller
	{
		KitapContext context = new KitapContext();
		public IActionResult Index()
		{
			var values = context.OduncIslemleri.Include(x=>x.Personel)
												.Include(x=>x.Kitap)
												.Include(x=>x.Uye)
				.ToList();
			return View(values);
			
		}
		public IActionResult CreateOduncIslem()
		{

			List<SelectListItem> deger = (from x in context.Uyeler.ToList()
										  select new SelectListItem
										  {
											  Text = x.AdSoyad,
											  Value = x.UyeId.ToString()
										  }).ToList();
			ViewBag.dgr1 = deger;
			List<SelectListItem> deger2 = (from x in context.Personeller.ToList()
										  select new SelectListItem
										  {
											  Text = x.AdSoyad,
											  Value = x.PersonelId.ToString()
										  }).ToList();
			ViewBag.dgr2 = deger2;
			List<SelectListItem> deger3 = (from x in context.Kitaplar.ToList()
										  select new SelectListItem
										  {
											  Text = x.Baslik,
											  Value = x.KitapId.ToString()
										  }).ToList();
			ViewBag.dgr3 = deger3;
			return View();
			
		}
		[HttpPost]
		public IActionResult CreateOduncIslem(OduncIslem oduncIslem)
		{
			context.OduncIslemleri.Add(oduncIslem);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteOduncIslem(int id)
		{
			var value = context.OduncIslemleri.Find(id);
			context.OduncIslemleri.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateOduncIslem(int id)
		{
			List<SelectListItem> deger = (from x in context.Uyeler.ToList()
										  select new SelectListItem
										  {
											  Text = x.AdSoyad,
											  Value = x.UyeId.ToString()
										  }).ToList();
			ViewBag.dgr1 = deger;
			List<SelectListItem> deger2 = (from x in context.Personeller.ToList()
										   select new SelectListItem
										   {
											   Text = x.AdSoyad,
											   Value = x.PersonelId.ToString()
										   }).ToList();
			ViewBag.dgr2 = deger2;
			List<SelectListItem> deger3 = (from x in context.Kitaplar.ToList()
										   select new SelectListItem
										   {
											   Text = x.Baslik,
											   Value = x.KitapId.ToString()
										   }).ToList();
			ViewBag.dgr3 = deger3;
			var value = context.OduncIslemleri.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateOduncIslem(OduncIslem oduncIslem)
		{
			context.OduncIslemleri.Update(oduncIslem);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
