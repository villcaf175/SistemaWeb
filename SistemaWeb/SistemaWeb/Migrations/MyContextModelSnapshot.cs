﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaWeb.Contexto;

#nullable disable

namespace SistemaWeb.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("SistemaWeb.Models.Alquiler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CanchaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad_Hora")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo_Total")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Desde")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<DateTime>("Hasta")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero_Recibo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Alquilers");
                });

            modelBuilder.Entity("SistemaWeb.Models.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero_Cancha")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("SistemaWeb.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ci")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaWeb.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaWeb.Models.Alquiler", b =>
                {
                    b.HasOne("SistemaWeb.Models.Cancha", "Cancha")
                        .WithMany("Alquilers")
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWeb.Models.Cliente", "Cliente")
                        .WithMany("Alquilers")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWeb.Models.Usuario", "Usuario")
                        .WithMany("Alquilers")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cancha");

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaWeb.Models.Cancha", b =>
                {
                    b.Navigation("Alquilers");
                });

            modelBuilder.Entity("SistemaWeb.Models.Cliente", b =>
                {
                    b.Navigation("Alquilers");
                });

            modelBuilder.Entity("SistemaWeb.Models.Usuario", b =>
                {
                    b.Navigation("Alquilers");
                });
#pragma warning restore 612, 618
        }
    }
}
