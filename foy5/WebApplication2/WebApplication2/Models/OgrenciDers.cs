using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class OgrenciDers
    {
        [Key]
        public int ogrenciDersID { get; set; }
        public int ogrenciID { get; set; }
        public int dersID { get; set; }
        public int yil { get; set; }
        public int yariyil { get; set; }
        public int vize { get; set; }
        public int final { get; set; }

        public Ogrenci Ogrenci { get; set; }
    }
}
