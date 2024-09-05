namespace Kitaplık.DAL.Entities
{
    public class Uye
    {
        public int UyeId { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime UyelikTarihi { get; set; }

        // Relationship with LoanTransactions
        public ICollection<OduncIslem> OduncIslemleri { get; set; }
    }
}
