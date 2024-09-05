using Kitaplık.DAL.Context;
using Kitaplık.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.Controllers
{
    public class KategoriController : Controller
    {
        KitapContext context = new KitapContext();
        public IActionResult Index()
        {
            var values = context.Kategoriler.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateKategori()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateKategori(Kategori kategori)
        {
            context.Kategoriler.Add(kategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteKategori(int id)
        {
            var value = context.Kategoriler.Find(id);
            context.Kategoriler.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateKategori(int id)
        {
            var value = context.Kategoriler.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateKategori(Kategori about)
        {
            context.Kategoriler.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
