using Microsoft.EntityFrameworkCore;

namespace ImssInventory.API.Models
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options):base(options)
        {

        }
        public DbSet<Position> Positions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computer { get; set; }

    }
}
