using Microsoft.EntityFrameworkCore;
using Zadatak.Models;

namespace Zadatak.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Zaposlenik> Zaposlenici { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}