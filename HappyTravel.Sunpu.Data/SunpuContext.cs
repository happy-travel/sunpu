using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Data
{
    public class SunpuContext : DbContext
    {
        public SunpuContext(DbContextOptions<SunpuContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Supplier>(e =>
            {
                e.ToTable("Suppliers");
                e.HasKey(c => c.Id);
                e.Property(c => c.Name).IsRequired();
            });
        }


        public DbSet<Supplier> Suppliers { get; set; }
    }
}
