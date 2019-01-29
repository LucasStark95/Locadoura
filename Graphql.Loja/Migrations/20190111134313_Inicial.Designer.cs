﻿// <auto-generated />
using Graphql.Loja.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Graphql.Loja.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    [Migration("20190111134313_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Graphql.Loja.Model.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano");

                    b.Property<int>("Diaria");

                    b.Property<string>("Modelo");

                    b.Property<int>("Velocidade");

                    b.HasKey("Id");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("Graphql.Loja.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Perfil");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Graphql.Loja.Model.Locacoes", b =>
                {
                    b.Property<int>("ClienteId");

                    b.Property<int>("CarroId");

                    b.HasKey("ClienteId", "CarroId");

                    b.HasIndex("CarroId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Graphql.Loja.Model.Locacoes", b =>
                {
                    b.HasOne("Graphql.Loja.Model.Carro", "Carro")
                        .WithMany("Locacoes")
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Graphql.Loja.Model.Cliente", "Cliente")
                        .WithMany("Locados")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
