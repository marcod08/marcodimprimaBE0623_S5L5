using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace S5L5.Models
{
    public class Verbale
    {
        [Key] 
        public int IdVerbale { get; set; }
        [Required]
        public int IdViolazione { get; set; }
        [Required]
        public int IdAnagrafica { get; set; }
        [Required]
        public DateTime DataViolazione {  set; get; }
        [Required]
        public string IndirizzoViolazione { get; set; }
        [Required]
        public string NominativoAgente { get; set; }
        [Required]
        public DateTime DataTrascrizioneVerbale { get; set; }
        [Required]
        public decimal Importo { get; set; }
        [Required]
        public int DecurtamentoPunti { get; set; }

    }
}
