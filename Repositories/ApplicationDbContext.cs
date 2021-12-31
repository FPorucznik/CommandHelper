using CommandHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandHelper.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Command>? Commands { get; set; }
    }
}