using Kitaplık.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kitaplık.DAL.Context
{
    public class KitapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-HJDDK6A0\\SQLEXPRESS; initial Catalog=KitaplıkProje; integrated Security=true;");
        }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<OduncIslem> OduncIslemleri { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
