using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Bolum
    {
        public int bolumID { get; set; }

        [MaxLength(15)]
        public string bolumAd { get; set; } = "";
        public int fakulteID { get; set; }

        public Fakulte Fakulte { get; set; }
    }
}
