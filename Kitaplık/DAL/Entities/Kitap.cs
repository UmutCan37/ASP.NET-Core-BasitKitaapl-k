namespace Kitaplık.DAL.Entities
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public string ISBN { get; set; }
        public int BasimYili { get; set; }
        public int Adet { get; set; }
        public bool Durum { get; set; }

        // Foreign key
        public int KategoriId { get; set; }

        // Navigation property
        public Kategori Kategori { get; set; }

        // Relationship with LoanTransactions
        public ICollection<OduncIslem> OduncIslemleri { get; set; }
		
	}
}
