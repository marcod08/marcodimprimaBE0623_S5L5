using System.ComponentModel.DataAnnotations;

namespace S5L5.Models
{
    public class TotaleVerbaliTrasgressore
    {
        [Key]
        public int IdAnagrafica { get; set; }
        public int TotaleVerbali { get; set; }
    }
}
