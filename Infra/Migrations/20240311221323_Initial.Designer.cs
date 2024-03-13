﻿// <auto-generated />
using System;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(SeradDbContext))]
    [Migration("20240311221323_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Cliente", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Representante")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("Tipo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Domain.Models.Endereco", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Cep")
                        .HasColumnType("text");

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<int?>("Numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Models.Endereco", b =>
                {
                    b.HasOne("Domain.Models.Cliente", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
