namespace S5L5.Models
{
    public class ViolazionePuntiAlta
    {
        public decimal Importo { get; set; }
        public int IdAnagrafica { get; set; }
        public DateTime DataViolazione { get; set; }
        public int DecurtamentoPunti { get; set; }
    }
}