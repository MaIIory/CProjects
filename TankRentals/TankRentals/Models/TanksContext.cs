using Microsoft.EntityFrameworkCore;

namespace TankRentals.Models
{
    public class TanksContext : DbContext
    {
        public TanksContext(DbContextOptions<TanksContext> options) : base(options)
        { }

        public DbSet<Tank> Tanks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<TankType> TankType { get; set; }
    }
}
