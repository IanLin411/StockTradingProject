using Microsoft.EntityFrameworkCore;
using StockTradingWebAPI.Model;
using StockTradingWebAPI.Model.Entities;

namespace StockTradingWebAPI.Data
{
    public class StockTradingContext : DbContext
    {
        public StockTradingContext(DbContextOptions<StockTradingContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(255);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            // Portfolio
            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Code).IsRequired().HasMaxLength(10);
                entity.Property(e => e.AveragePrice).HasColumnType("decimal(18,4)");
                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18,4)");
                entity.Property(e => e.CreateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                
                // 外鍵
                entity.HasOne(p => p.User)
                      .WithMany(u => u.Portfolio)
                      .HasForeignKey(p => p.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
                      
                // 複合索引：每個用戶的每個股票只能有一筆記錄
                entity.HasIndex(p => new { p.UserId, p.Code }).IsUnique();
            });

            // Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Symbol).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Price).HasColumnType("decimal(18,4)");
                entity.Property(e => e.CreateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                
                // 設定 Enum 轉換
                entity.Property(e => e.Type).HasConversion<int>();
                entity.Property(e => e.Status).HasConversion<int>();
                
                // 外鍵關係
                entity.HasOne(o => o.User)
                      .WithMany(u => u.Orders)
                      .HasForeignKey(o => o.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
                      
                // 索引
                entity.HasIndex(o => o.UserId);
                entity.HasIndex(o => o.Symbol);
                entity.HasIndex(o => o.CreateTime);
            });
        }
    }
}