using ManagermentStore.Core;
using Microsoft.EntityFrameworkCore;

namespace ManagermentStore
{
    public class ManagermentStoreContext : DbContext
    {
        public ManagermentStoreContext(DbContextOptions<ManagermentStoreContext> options) : base(options)
        { }
        public virtual DbSet<Store> Stores { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne<Store>(s => s.Store)
                .WithMany(g => g.Employees)
                .HasForeignKey(s => s.StoreId);
        }
    }
}
