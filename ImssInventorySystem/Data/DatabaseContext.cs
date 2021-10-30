using ImssInventorySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ImssInventorySystem.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
