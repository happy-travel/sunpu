using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Data;

public class SunpuContext : DbContext
{
    public SunpuContext(DbContextOptions<SunpuContext> options) : base(options)
    { }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Supplier>(e =>
        {
            e.ToTable("Suppliers");
            e.HasKey(s => s.Id);
            e.Property(s => s.Name).IsRequired();
            e.Property(s => s.IsEnable).IsRequired();
            e.Property(s => s.ConnectorUrl).IsRequired();
            e.Property(s => s.Created).IsRequired();
            e.Property(s => s.Modified).IsRequired();
        });
    }


    public DbSet<Supplier> Suppliers { get; set; }
}
