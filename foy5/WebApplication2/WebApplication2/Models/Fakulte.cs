using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication2.Models
{
    public class Fakulte
    {
        public int fakulteID { get; set; }

        [MaxLength(15)]
        public string fakulteAd { get; set; } = "";
    }
}
