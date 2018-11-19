using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FrotaSisWeb.Models.SisModels
{
    public partial class G3DBSContext : DbContext
    {
        public G3DBSContext()
        {
        }

        public G3DBSContext(DbContextOptions<G3DBSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FrotaTipoFrota> FrotaTipoFrota { get; set; }
        public virtual DbSet<SisMarcas> SisMarcas { get; set; }
        public virtual DbSet<SisUf> SisUf { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {/*
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HRMES0O;Initial Catalog=G3DBS;User ID=g3;Password=g3sql@_2016");
                */
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrotaTipoFrota>(entity =>
            {
                entity.HasKey(e => e.Codigotpfrota);

                entity.ToTable("frota_tipo_frota");

                entity.Property(e => e.Codigotpfrota)
                    .HasColumnName("codigotpfrota")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DescTpfrota)
                    .HasColumnName("desc_tpfrota")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SisMarcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("sis_marcas");

                entity.Property(e => e.IdMarca)
                    .HasColumnName("id_marca")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.DescMarca)
                    .IsRequired()
                    .HasColumnName("desc_marca")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Usacadmat).HasColumnName("usacadmat");

                entity.Property(e => e.Usacadveic).HasColumnName("usacadveic");
            });

            modelBuilder.Entity<SisUf>(entity =>
            {
                entity.HasKey(e => e.IdUf);

                entity.ToTable("sis_uf");

                entity.HasIndex(e => e.DescUf)
                    .HasName("UQ__sis_uf__D0316EE7A7F17A37")
                    .IsUnique();

                entity.Property(e => e.IdUf)
                    .HasColumnName("id_uf")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescUf)
                    .IsRequired()
                    .HasColumnName("desc_uf")
                    .HasMaxLength(30);
            });
        }
    }
}
