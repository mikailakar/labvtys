using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Ogrenci
    {
        public int ogrenciID { get; set; }

        [MaxLength(15)]
        public string ad { get; set; } = "";

        [MaxLength(15)]
        public string soyad { get; set; } = "";
        public int bolumID { get; set; }
        public Bolum Bolum { get; set; }
    }
}
