using Microsoft.EntityFrameworkCore;
using NguyenHuuThang_241224490.Models.Models.Models.Models;

namespace NguyenHuuThang_241224490.Models;

public class QLNhaSachContext : DbContext
{
    public QLNhaSachContext(DbContextOptions<QLNhaSachContext> options) : base(options) { }

    public DbSet<TheLoai> TheLoais { get; set; }
    public DbSet<Sach> Saches { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<TheLoai>(e =>
        {
            e.ToTable("TheLoai");
            e.HasKey(x => x.MaTl);
            e.Property(x => x.MaTl).HasColumnName("MaTL");
            e.Property(x => x.TenTl).HasColumnName("TenTL").HasMaxLength(50);
        });

        mb.Entity<Sach>(e =>
        {
            e.ToTable("Sach");
            e.HasKey(x => x.MaSach);
            e.Property(x => x.MaTl).HasColumnName("MaTL");
            e.Property(x => x.Gia).HasColumnType("numeric(18, 0)");
            e.HasOne(x => x.MaTlNavigation)
             .WithMany(t => t.Saches)
             .HasForeignKey(x => x.MaTl);
        });
    }
}