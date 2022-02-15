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
            e.Property(s => s.Code).IsRequired();
            e.Property(s => s.Name).IsRequired();
            e.Property(s => s.IsEnabled).IsRequired();
            e.Property(s => s.ConnectorUrl).IsRequired();
            e.Property(s => s.IsMultiRoomFlowSupported).IsRequired();
            e.Property(s => s.WebSite);
            e.Property(s => s.PrimaryContact).HasColumnType("jsonb");
            e.Property(s => s.SupportContacts).HasColumnType("jsonb");
            e.Property(s => s.ReservationsContacts).HasColumnType("jsonb");
            e.Property(s => s.Created).IsRequired();
            e.Property(s => s.Modified);
            e.Property(s => s.CustomHeaders).HasColumnType("jsonb");
        });

        builder.Entity<SupplierActivationHistoryEntry>(e =>
        {
            e.ToTable("SupplierActivationHistory");
            e.HasKey(h => h.Id);
            e.Property(h => h.SupplierId).IsRequired();
            e.Property(h => h.IsEnabled).IsRequired();
            e.Property(h => h.Reason).IsRequired();
            e.Property(h => h.Created).IsRequired();
        });
    }


    public DbSet<Supplier> Suppliers { get; set; } = null!;
    public DbSet<SupplierActivationHistoryEntry> SupplierActivationHistory { get; set; } = null!;
}
