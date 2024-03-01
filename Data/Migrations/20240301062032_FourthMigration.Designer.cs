﻿// <auto-generated />
using System;
using Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(Entrega5DbContext))]
    [Migration("20240301062032_FourthMigration")]
    partial class FourthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cuil")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Data.Modelos.Cobranza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("montoTotal")
                        .HasColumnType("real");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cobranza");
                });

            modelBuilder.Entity("Data.Modelos.Cuota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("cobranzaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fechaIni")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("monto")
                        .HasColumnType("real");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.Property<int>("ventaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("cobranzaId");

                    b.HasIndex("ventaId");

                    b.ToTable("Cuota");
                });

            modelBuilder.Entity("Data.Modelos.Domicilio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("calle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("clienteId")
                        .HasColumnType("integer");

                    b.Property<int>("localidadId")
                        .HasColumnType("integer");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.HasIndex("localidadId");

                    b.ToTable("Domicilio");
                });

            modelBuilder.Entity("Data.Modelos.Efectivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("cobranzaId")
                        .HasColumnType("integer");

                    b.Property<float>("montoParticular")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("cobranzaId");

                    b.ToTable("Efectivo");
                });

            modelBuilder.Entity("Data.Modelos.Insumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("codigo")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Insumo");
                });

            modelBuilder.Entity("Data.Modelos.ListaPrecio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("tipoCondicionPago")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ListaPrecio");
                });

            modelBuilder.Entity("Data.Modelos.ListaPrecioInsumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("insumoId")
                        .HasColumnType("integer");

                    b.Property<int>("listaPrecioId")
                        .HasColumnType("integer");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("insumoId");

                    b.HasIndex("listaPrecioId");

                    b.ToTable("ListaPrecioInsumo");
                });

            modelBuilder.Entity("Data.Modelos.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("provinciaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("provinciaId");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("Data.Modelos.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("Data.Modelos.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("paisId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("paisId");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Data.Modelos.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("banco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("cobranzaId")
                        .HasColumnType("integer");

                    b.Property<float>("montoParticular")
                        .HasColumnType("real");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("cobranzaId");

                    b.ToTable("Tarjeta");
                });

            modelBuilder.Entity("Data.Modelos.TipoCondicionPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TipoCondicionPago");
                });

            modelBuilder.Entity("Data.Modelos.TransferenciaBancaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("cobranzaId")
                        .HasColumnType("integer");

                    b.Property<int>("cuentaDestino")
                        .HasColumnType("integer");

                    b.Property<int>("cuentaOrigen")
                        .HasColumnType("integer");

                    b.Property<float>("montoParticular")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("cobranzaId");

                    b.ToTable("TransferenciaBancaria");
                });

            modelBuilder.Entity("Data.Modelos.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("clienteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fechaIni")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("importeTotal")
                        .HasColumnType("real");

                    b.Property<int>("numeroVenta")
                        .HasColumnType("integer");

                    b.Property<string>("tipoCondicionPago")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("Data.Modelos.VentaDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("cantidad")
                        .HasColumnType("integer");

                    b.Property<int>("insumoId")
                        .HasColumnType("integer");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.Property<int>("ventaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("insumoId");

                    b.HasIndex("ventaId");

                    b.ToTable("VentaDetalle");
                });

            modelBuilder.Entity("Data.Modelos.Cuota", b =>
                {
                    b.HasOne("Data.Modelos.Cobranza", "cobranza")
                        .WithMany()
                        .HasForeignKey("cobranzaId");

                    b.HasOne("Data.Modelos.Venta", "venta")
                        .WithMany("cuotas")
                        .HasForeignKey("ventaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cobranza");

                    b.Navigation("venta");
                });

            modelBuilder.Entity("Data.Modelos.Domicilio", b =>
                {
                    b.HasOne("Data.Modelos.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Modelos.Localidad", "localidad")
                        .WithMany()
                        .HasForeignKey("localidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("localidad");
                });

            modelBuilder.Entity("Data.Modelos.Efectivo", b =>
                {
                    b.HasOne("Data.Modelos.Cobranza", "cobranza")
                        .WithMany()
                        .HasForeignKey("cobranzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cobranza");
                });

            modelBuilder.Entity("Data.Modelos.ListaPrecioInsumo", b =>
                {
                    b.HasOne("Data.Modelos.Insumo", "insumo")
                        .WithMany()
                        .HasForeignKey("insumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Modelos.ListaPrecio", "listaPrecio")
                        .WithMany()
                        .HasForeignKey("listaPrecioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("insumo");

                    b.Navigation("listaPrecio");
                });

            modelBuilder.Entity("Data.Modelos.Localidad", b =>
                {
                    b.HasOne("Data.Modelos.Provincia", "provincia")
                        .WithMany()
                        .HasForeignKey("provinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("provincia");
                });

            modelBuilder.Entity("Data.Modelos.Provincia", b =>
                {
                    b.HasOne("Data.Modelos.Pais", "pais")
                        .WithMany()
                        .HasForeignKey("paisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pais");
                });

            modelBuilder.Entity("Data.Modelos.Tarjeta", b =>
                {
                    b.HasOne("Data.Modelos.Cobranza", "cobranza")
                        .WithMany()
                        .HasForeignKey("cobranzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cobranza");
                });

            modelBuilder.Entity("Data.Modelos.TransferenciaBancaria", b =>
                {
                    b.HasOne("Data.Modelos.Cobranza", "cobranza")
                        .WithMany()
                        .HasForeignKey("cobranzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cobranza");
                });

            modelBuilder.Entity("Data.Modelos.Venta", b =>
                {
                    b.HasOne("Data.Modelos.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Data.Modelos.VentaDetalle", b =>
                {
                    b.HasOne("Data.Modelos.Insumo", "insumo")
                        .WithMany()
                        .HasForeignKey("insumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Modelos.Venta", "venta")
                        .WithMany()
                        .HasForeignKey("ventaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("insumo");

                    b.Navigation("venta");
                });

            modelBuilder.Entity("Data.Modelos.Venta", b =>
                {
                    b.Navigation("cuotas");
                });
#pragma warning restore 612, 618
        }
    }
}
