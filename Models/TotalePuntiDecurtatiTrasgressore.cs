using System.ComponentModel.DataAnnotations;

namespace S5L5.Models
{
    public class TotalePuntiDecurtatiTrasgressore
    {
        [Key]
        public int IdAnagrafica { get; set; }
        public int TotalePuntiDecurtati { get; set; }
    }
}

