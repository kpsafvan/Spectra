using Microsoft.EntityFrameworkCore;
using Spectra.Models;

namespace Spectra.Data
{
    public class SpectraDbContext : DbContext
    {
        public SpectraDbContext(DbContextOptions<SpectraDbContext> options)
            : base(options)
        {
        }

        //public DbSet<SpectraItem> SpectreItems { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Product> Products { get; set; }

    }
    //public class SpectraItem
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //}
}
