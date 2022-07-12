using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HSPA.Models
{
    public partial class HSPAContext : DbContext
    {
        public HSPAContext()
        {
        }

        public HSPAContext(DbContextOptions<HSPAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblProperty> TblProperty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblProperty>(entity =>
            {
                entity.ToTable("tbl_Property");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Facing)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FurnishedStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Price).IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.ToTable("tbl_Account");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
