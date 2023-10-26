﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace p25_simple_crud.Migrations
{
    [DbContext(typeof(ContextoDatos))]
    partial class ContextoDatosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genero")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rfc")
                        .HasColumnType("TEXT");

                    b.Property<double>("Salario")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
