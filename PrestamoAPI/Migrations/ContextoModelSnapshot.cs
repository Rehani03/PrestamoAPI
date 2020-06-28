﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrestamoAPI.DAL;

namespace PrestamoAPI.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("PrestamoAPI.Models.Personas", b =>
                {
                    b.Property<int>("personaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.HasKey("personaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("PrestamoAPI.Models.Prestamo", b =>
                {
                    b.Property<int>("prestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("concepto")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("personaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("prestamoId");

                    b.ToTable("Prestamos");
                });
#pragma warning restore 612, 618
        }
    }
}
