﻿// <auto-generated />
using System;
using ClienteLabs.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClienteLabs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240731004959_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClienteLabs.Models.Cliente", b =>
                {
                    b.Property<string>("CPFCNPJ")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("InscricaoEstadual")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CPFCNPJ");

                    b.HasIndex("GeneroId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClienteLabs.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneroId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneroId");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("ClienteLabs.Models.Login", b =>
                {
                    b.Property<string>("CPFCNPJ")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("bit");

                    b.Property<string>("ClienteCPFCNPJ")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CPFCNPJ");

                    b.HasIndex("ClienteCPFCNPJ");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("ClienteLabs.Models.Cliente", b =>
                {
                    b.HasOne("ClienteLabs.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("ClienteLabs.Models.Login", b =>
                {
                    b.HasOne("ClienteLabs.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteCPFCNPJ");

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
