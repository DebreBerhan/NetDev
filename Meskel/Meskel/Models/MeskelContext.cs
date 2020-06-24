using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Meskel.Models
{
    public partial class MeskelContext : DbContext
    {
        public MeskelContext()
        {
        }

        public MeskelContext(DbContextOptions<MeskelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beads> Beads { get; set; }
        public virtual DbSet<Design> Design { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Meskel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beads>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("beads");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Design>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImageFile)
                    .HasColumnName("image")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.PpImage).HasColumnName("pp_image");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
