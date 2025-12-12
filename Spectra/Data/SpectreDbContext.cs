using Microsoft.EntityFrameworkCore;

namespace Spectra.Data
{
    public class SpectreDbContext : DbContext
    {
        public SpectreDbContext(DbContextOptions<SpectreDbContext> options)
            : base(options)
        {
        }

        public DbSet<SpectreItem> SpectreItems { get; set; }
    }
    public class SpectreItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
