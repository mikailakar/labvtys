using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class BolumDto
    {
        [Required]
        public int bolumID { get; set; }

        [Required, MaxLength(15)]
        public string bolumAd { get; set; } = "";

        [Required]
        public int fakulteID { get; set; }
    }
}
