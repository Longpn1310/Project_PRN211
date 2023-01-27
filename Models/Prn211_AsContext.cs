using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Project_PRN211.Models
{
    public partial class Prn211_AsContext : DbContext
    {
        public Prn211_AsContext()
        {
        }

        public Prn211_AsContext(DbContextOptions<Prn211_AsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTieu> ChiTieus { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Wallet> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                             .SetBasePath(Directory.GetCurrentDirectory())
                                             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTieu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChiTieu");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Ghi chu");

                entity.Property(e => e.LoaiChi)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiChiTieu)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaychi).HasColumnType("date");

                entity.Property(e => e.SoTienChi).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("Wallet");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.KeHoach).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TongDu).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
