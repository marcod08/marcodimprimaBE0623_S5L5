using Microsoft.EntityFrameworkCore;

namespace S5L5.Models
{
    public class PoliziaDbContext : DbContext
    {
        public PoliziaDbContext(DbContextOptions<PoliziaDbContext> options) : base(options)
        {
        }

        public DbSet<Verbale> Verbale { get; set; }
        public DbSet<Anagrafica> Anagrafica { get; set; }
        public DbSet<Violazione> Violazione { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-MARCO\\SQLEXPRESS;Database=PoliziaMunicipale;Integrated Security=true;Encrypt=false;");
            }
        }
    }
}