using System.ComponentModel.DataAnnotations;

namespace Kitaplık.DAL.Entities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public string KullanıcıAdi { get; set; }

        public string Şifre { get; set; }
    }
}
