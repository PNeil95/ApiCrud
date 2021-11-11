using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebServicesBlazorCrud.Models
{
    public partial class BlazorCrudContext : DbContext
    {
        public BlazorCrudContext()
        {
        }

        public BlazorCrudContext(DbContextOptions<BlazorCrudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Heroe> Heroes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-MRII35AO; Database= BlazorCrud;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Heroe>(entity =>
            {
                entity.ToTable("Heroe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Poder)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("poder");

                entity.Property(e => e.Universo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("universo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
