﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentalKendaraan_076.Models
{
    public partial class RentalKendaraanContext : DbContext
    {
        public RentalKendaraanContext()
        {
        }

        public RentalKendaraanContext(DbContextOptions<RentalKendaraanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Jaminan> Jaminan { get; set; }
        public virtual DbSet<JenisKendaraan> JenisKendaraan { get; set; }
        public virtual DbSet<Kendaraan> Kendaraan { get; set; }
        public virtual DbSet<KondisiKendaraan> KondisiKendaraan { get; set; }
        public virtual DbSet<Peminjaman> Peminjaman { get; set; }
        public virtual DbSet<Pengembalian> Pengembalian { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer).HasColumnName("ID_Customer");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdGender).HasColumnName("ID_Gender");

                entity.Property(e => e.NamaCustomer)
                    .IsRequired()
                    .HasColumnName("Nama_Customer")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .HasColumnName("NIK")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NoHp)
                    .HasColumnName("NO_HP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGenderNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.IdGender)
                    .HasConstraintName("FK_Customer_Gender");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.IdGender);

                entity.Property(e => e.IdGender).HasColumnName("ID_Gender");

                entity.Property(e => e.NamaGender)
                    .IsRequired()
                    .HasColumnName("Nama_Gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jaminan>(entity =>
            {
                entity.HasKey(e => e.IdJaminan);

                entity.Property(e => e.IdJaminan).HasColumnName("ID_Jaminan");

                entity.Property(e => e.NamaJaminan)
                    .IsRequired()
                    .HasColumnName("Nama_Jaminan")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JenisKendaraan>(entity =>
            {
                entity.HasKey(e => e.IdJenisKendaraan);

                entity.ToTable("Jenis_Kendaraan");

                entity.Property(e => e.IdJenisKendaraan).HasColumnName("ID_Jenis_Kendaraan");

                entity.Property(e => e.NamaJenisKendaraan)
                    .IsRequired()
                    .HasColumnName("Nama_Jenis_Kendaraan")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kendaraan>(entity =>
            {
                entity.HasKey(e => e.IdKendaraan);

                entity.Property(e => e.IdKendaraan).HasColumnName("ID_Kendaraan");

                entity.Property(e => e.IdJenisKendaraan).HasColumnName("ID_Jenis_Kendaraan");

                entity.Property(e => e.Ketersediaan)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKendaraan)
                    .IsRequired()
                    .HasColumnName("Nama_Kendaraan")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NoPolisi)
                    .HasColumnName("No_Polisi")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NoStnk)
                    .HasColumnName("No_STNK")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdJenisKendaraanNavigation)
                    .WithMany(p => p.Kendaraan)
                    .HasForeignKey(d => d.IdJenisKendaraan)
                    .HasConstraintName("FK_Kendaraan_Jenis_Kendaraan");
            });

            modelBuilder.Entity<KondisiKendaraan>(entity =>
            {
                entity.HasKey(e => e.IdKondisi);

                entity.ToTable("Kondisi_Kendaraan");

                entity.Property(e => e.IdKondisi).HasColumnName("ID_Kondisi");

                entity.Property(e => e.Kondisi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Peminjaman>(entity =>
            {
                entity.HasKey(e => e.IdPeminjaman);

                entity.Property(e => e.IdPeminjaman).HasColumnName("ID_Peminjaman");

                entity.Property(e => e.IdCostumer).HasColumnName("ID_Costumer");

                entity.Property(e => e.IdJaminan).HasColumnName("ID_Jaminan");

                entity.Property(e => e.IdKendaraan).HasColumnName("ID_Kendaraan");

                entity.Property(e => e.TglPeminjaman)
                    .HasColumnName("Tgl_Peminjaman")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdCostumerNavigation)
                    .WithMany(p => p.Peminjaman)
                    .HasForeignKey(d => d.IdCostumer)
                    .HasConstraintName("FK_Peminjaman_Customer");

                entity.HasOne(d => d.IdCostumer1)
                    .WithMany(p => p.Peminjaman)
                    .HasForeignKey(d => d.IdCostumer)
                    .HasConstraintName("FK_Peminjaman_Kendaraan");

                entity.HasOne(d => d.IdJaminanNavigation)
                    .WithMany(p => p.Peminjaman)
                    .HasForeignKey(d => d.IdJaminan)
                    .HasConstraintName("FK_Peminjaman_Jaminan");
            });

            modelBuilder.Entity<Pengembalian>(entity =>
            {
                entity.HasKey(e => e.IdPengembalian);

                entity.Property(e => e.IdPengembalian).HasColumnName("ID_Pengembalian");

                entity.Property(e => e.IdKondisi).HasColumnName("ID_Kondisi");

                entity.Property(e => e.IdPeminjaman).HasColumnName("ID_Peminjaman");

                entity.Property(e => e.TglPengembalian)
                    .HasColumnName("Tgl_Pengembalian")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdKondisiNavigation)
                    .WithMany(p => p.Pengembalian)
                    .HasForeignKey(d => d.IdKondisi)
                    .HasConstraintName("FK_Pengembalian_Kondisi_Kendaraan");

                entity.HasOne(d => d.IdPeminjamanNavigation)
                    .WithMany(p => p.Pengembalian)
                    .HasForeignKey(d => d.IdPeminjaman)
                    .HasConstraintName("FK_Pengembalian_Peminjaman");
            });
        }
    }
}
