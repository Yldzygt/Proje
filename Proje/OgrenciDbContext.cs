using Microsoft.EntityFrameworkCore;
using Proje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class OgrenciDbContext : DbContext
    {
        public DbSet<Ogrenci> tblOgrenciler { get; set; }
        public DbSet<Sinif> tblSiniflar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2V61350\MS2024;Initial Catalog=Proje;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Öğrenci
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Ad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Soyad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Numara).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().HasIndex(o => o.Numara).IsUnique();
            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId);

            // Sınıf
            modelBuilder.Entity<Sinif>()
                .Property(d => d.SinifAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Sinif>().HasIndex(s => s.SinifAd).IsUnique();

            // Ders
            modelBuilder.Entity<Ders>()
                .Property(d => d.DersAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ders>()
                .Property(d => d.DersKod).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ders>().HasIndex(d => d.DersKod).IsUnique();

            // OgrenciDers
            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDers)
                .HasForeignKey(od => od.OgrenciId);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDers)
                .HasForeignKey(od => od.DersId);
        }
    }
}
