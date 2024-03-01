using System.ComponentModel.DataAnnotations;

namespace S5L5.Models
{
    public class Violazione
    {
        [Key] 
        public int IdViolazione { get; set; }
        [Required]
        public string Descrizione { get; set; }
    }
}
