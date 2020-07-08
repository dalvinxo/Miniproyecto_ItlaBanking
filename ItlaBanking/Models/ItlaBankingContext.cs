using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ItlaBanking.Models
{
    public partial class ItlaBankingContext : IdentityDbContext
    {
        public ItlaBankingContext()
        {
        }

        public ItlaBankingContext(DbContextOptions<ItlaBankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beneficiario> Beneficiario { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Prestamos> Prestamos { get; set; }
        public virtual DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-DK0MCFF;Database=ItlaBanking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Beneficiario>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuarioCliente, e.IdUsuarioBeneficiario });

                entity.HasOne(d => d.IdUsuarioBeneficiarioNavigation)
                    .WithMany(p => p.BeneficiarioIdUsuarioBeneficiarioNavigation)
                    .HasForeignKey(d => d.IdUsuarioBeneficiario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Beneficia__IdUsu__3E52440B");

                entity.HasOne(d => d.IdUsuarioClienteNavigation)
                    .WithMany(p => p.BeneficiarioIdUsuarioClienteNavigation)
                    .HasForeignKey(d => d.IdUsuarioCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Beneficia__IdUsu__3D5E1FD2");
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.NumeroCuenta);

                entity.Property(e => e.NumeroCuenta).ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.FechaAdquisicion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usu_cut");
            });

            modelBuilder.Entity<Prestamos>(entity =>
            {
                entity.HasKey(e => e.NumeroPrestamo);

                entity.Property(e => e.NumeroPrestamo).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Activo')");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Monto).HasColumnType("decimal(13, 2)");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pre_usu");
            });

            modelBuilder.Entity<TarjetaCredito>(entity =>
            {
                entity.HasKey(e => e.NumeroTarjeta);

                entity.Property(e => e.NumeroTarjeta).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Activo')");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MontoLimite).HasColumnType("decimal(13, 2)");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TarjetaCredito)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_taj_usu");
            });

            modelBuilder.Entity<Transacciones>(entity =>
            {
                entity.HasKey(e => e.IdTransacciones);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Monto).HasColumnType("decimal(13, 2)");

                entity.HasOne(d => d.NumeroCuentaNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.NumeroCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cut_tra");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Inactivo')");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUsuario)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Cliente')");

                entity.Property(e => e.Usuario1)
                    .HasColumnName("Usuario")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
        }
    }
}
