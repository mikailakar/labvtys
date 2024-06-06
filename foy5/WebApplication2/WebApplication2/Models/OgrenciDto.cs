using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class OgrenciDto
    {
        [Required]
        public int ogrenciID { get; set; }

        [Required, MaxLength(15)]
        public string ad { get; set; } = "";

        [Required, MaxLength(15)]
        public string soyad { get; set; } = "";

        [Required]
        public int bolumID { get; set; }
    }
}
