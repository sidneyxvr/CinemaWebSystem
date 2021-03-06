﻿// <auto-generated />
using CinemaWebSystem.Data;
using CinemaWebSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CinemaWebSystem.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20180719020545_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaWebSystem.Models.Assento", b =>
                {
                    b.Property<int>("AssentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativa");

                    b.Property<string>("Fila")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("Numero");

                    b.Property<int>("SalaId");

                    b.HasKey("AssentoId");

                    b.HasIndex("SalaId");

                    b.ToTable("Assentos");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Cinema", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativa");

                    b.Property<string>("Bairro")
                        .HasMaxLength(50);

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Numero");

                    b.Property<string>("Rua")
                        .HasMaxLength(50);

                    b.HasKey("CinemaId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativa");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("Estudante");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("SenhaCofirmada")
                        .IsRequired();

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativa");

                    b.Property<int>("Classificacao");

                    b.Property<int>("GeneroId");

                    b.Property<byte[]>("Imagem");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("FilmeId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("GeneroId");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Ingresso", b =>
                {
                    b.Property<int>("IngressoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssentoId");

                    b.Property<bool>("Estudante");

                    b.Property<int>("SessaoId");

                    b.Property<int>("VendaId");

                    b.HasKey("IngressoId");

                    b.HasIndex("AssentoId");

                    b.HasIndex("SessaoId");

                    b.HasIndex("VendaId");

                    b.ToTable("Ingressos");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativa");

                    b.Property<int>("CinemaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("QuantidadeAssentos");

                    b.HasKey("SalaId");

                    b.HasIndex("CinemaId");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Sessao", b =>
                {
                    b.Property<int>("SessaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativa");

                    b.Property<int>("CinemaId");

                    b.Property<int>("FilmeId");

                    b.Property<DateTime>("Horario");

                    b.Property<decimal>("Preco");

                    b.Property<int>("SalaId");

                    b.HasKey("SessaoId");

                    b.HasIndex("CinemaId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessoes");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cartao");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Inteira");

                    b.Property<int>("Meia");

                    b.Property<int>("SessaoId");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("VendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("SessaoId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Assento", b =>
                {
                    b.HasOne("CinemaWebSystem.Models.Sala", "Sala")
                        .WithMany("Assentos")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Filme", b =>
                {
                    b.HasOne("CinemaWebSystem.Models.Genero", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Ingresso", b =>
                {
                    b.HasOne("CinemaWebSystem.Models.Assento", "Assento")
                        .WithMany("Ingressos")
                        .HasForeignKey("AssentoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebSystem.Models.Sessao", "Sessao")
                        .WithMany("Ingressos")
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebSystem.Models.Venda", "Venda")
                        .WithMany("Ingressos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Sala", b =>
                {
                    b.HasOne("CinemaWebSystem.Models.Cinema", "Cinema")
                        .WithMany("Salas")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Sessao", b =>
                {
                    b.HasOne("CinemaWebSystem.Models.Cinema", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebSystem.Models.Filme", "Filme")
                        .WithMany("Sessoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebSystem.Models.Sala", "Sala")
                        .WithMany("Sessoes")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebSystem.Models.Venda", b =>
                {
                    b.HasOne("CinemaWebSystem.Models.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebSystem.Models.Sessao", "Sessao")
                        .WithMany("Vendas")
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
