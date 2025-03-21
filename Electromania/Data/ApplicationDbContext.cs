using Electromania.Models;
using Microsoft.EntityFrameworkCore;



namespace Electromania.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Articulos> articulos { get; set; }

    }
}
