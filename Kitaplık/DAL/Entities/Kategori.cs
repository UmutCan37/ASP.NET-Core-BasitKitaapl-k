namespace Kitaplık.DAL.Entities
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }

        // Relationship with Books
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
