using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class OgrenciDersDto
    {
        [Required]
        public int ogrenciID { get; set; }

        [Required]
        public int dersID { get; set; }

        [Required]
        public int yil { get; set; }

        [Required]
        public int yariyil { get; set; }
        public int vize { get; set; }
        public int final { get; set; }
    }
}
