using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace S5L5.Models
{
    public class Anagrafica
    {
        [Key] 
        public int IdAnagrafica { get; set; }
        [Required] 
        public string Cognome { get; set; }
        [Required] 
        public string Nome { get; set; }
        [Required] 
        public string Indirizzo { get; set; }
        [Required] 
        public string Città { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 5)]
        public string CAP { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 16)]
        public string CodFisc { get; set; }
    }
}
