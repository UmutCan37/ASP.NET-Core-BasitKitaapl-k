namespace Kitaplık.DAL.Entities
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public string Pozisyon { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime BaslamaTarihi { get; set; }

        // Relationship with LoanTransactions
        public ICollection<OduncIslem> OduncIslemleri { get; set; }
    }
}
