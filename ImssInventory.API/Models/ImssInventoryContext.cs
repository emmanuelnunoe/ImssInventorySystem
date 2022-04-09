using Microsoft.EntityFrameworkCore;

namespace ImssInventory.API.Models
{
    public class ImssInventoryContext : DbContext
    {
        public ImssInventoryContext(DbContextOptions<ImssInventoryContext> options) : base(options)
        {

        }

        public ImssInventoryContext()
        {
        }
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<OS> OS { get; set; } = null!;
        public DbSet<Monitor> Monitors { get; set; } = null!;
        public DbSet<Software> Softwares { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<PcAccountancyData> PcAccountancyData { get; set; } = null!;
        public DbSet<PcDomainInformation> PcDomainInformation { get; set; } = null!;
        public DbSet<Domain> Domains { get; set; } = null!;
        public DbSet<Maintenance> Maintenances { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<ITUser> ITUsers { get; set; } = null!;
        public DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public DbSet<Computer> Computers { get; set; } = null!;
        public DbSet<PcUpdate> PcUpdates { get; set; }=null!;


    }
}   
