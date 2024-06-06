using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class FakulteDto
    {
        [Required]
        public int fakulteID { get; set; }

        [Required, MaxLength(15)]
        public string fakulteAd { get; set; } = "";
    }
}
