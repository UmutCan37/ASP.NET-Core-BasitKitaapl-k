namespace Kitaplık.DAL.Entities
{
    public class OduncIslem
    {

        public int OduncIslemId { get; set; }

        // Foreign keys
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public int PersonelId { get; set; }

        public DateTime OduncAlmaTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
        public string Durum { get; set; }

        // Navigation properties
        public Kitap Kitap { get; set; }
        public Uye Uye { get; set; }
        public Personel Personel { get; set; }
    }
}
