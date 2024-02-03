﻿// <auto-generated />
using System;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Aeroporto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CidadeID")
                        .HasColumnType("bigint");

                    b.Property<string>("CodigoIATA")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("IataID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CidadeID");

                    b.HasIndex("IataID");

                    b.ToTable("Aeroportos");
                });

            modelBuilder.Entity("Domain.Entities.Bagagem", b =>
                {
                    b.Property<long>("BagagemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("BagagemID"));

                    b.Property<long>("PassagemID")
                        .HasColumnType("bigint");

                    b.HasKey("BagagemID");

                    b.HasIndex("PassagemID");

                    b.ToTable("Bagagens");
                });

            modelBuilder.Entity("Domain.Entities.Cidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("Domain.Entities.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("QuantidadeAssentos")
                        .HasColumnType("integer");

                    b.Property<int>("TipoClasse")
                        .HasColumnType("integer");

                    b.Property<decimal>("ValorAssento")
                        .HasColumnType("numeric");

                    b.Property<int>("VooID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VooID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.Property<long>("CompraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CompraID"));

                    b.Property<long>("ClasseID")
                        .HasColumnType("bigint");

                    b.Property<int>("ClasseId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CompraDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("PassageiroID")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantidadePassagens")
                        .HasColumnType("integer");

                    b.Property<long>("VooID")
                        .HasColumnType("bigint");

                    b.Property<int>("VooId")
                        .HasColumnType("integer");

                    b.HasKey("CompraID");

                    b.HasIndex("ClasseId");

                    b.HasIndex("PassageiroID");

                    b.HasIndex("VooId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Domain.Entities.Gestor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Gestores");
                });

            modelBuilder.Entity("Domain.Entities.Iata", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Iatas");
                });

            modelBuilder.Entity("Domain.Entities.Passageiro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Dtnascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idade")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Passageiros");
                });

            modelBuilder.Entity("Domain.Entities.Passagem", b =>
                {
                    b.Property<long>("PassagemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("PassagemID"));

                    b.Property<long>("ClasseID")
                        .HasColumnType("bigint");

                    b.Property<int>("ClasseId")
                        .HasColumnType("integer");

                    b.Property<long>("CompraID")
                        .HasColumnType("bigint");

                    b.Property<long>("PassageiroID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PrecoTotal")
                        .HasColumnType("numeric");

                    b.Property<long>("VooID")
                        .HasColumnType("bigint");

                    b.Property<int>("VooId")
                        .HasColumnType("integer");

                    b.HasKey("PassagemID");

                    b.HasIndex("ClasseId");

                    b.HasIndex("CompraID");

                    b.HasIndex("PassageiroID");

                    b.HasIndex("VooId");

                    b.ToTable("Passagens");
                });

            modelBuilder.Entity("Domain.Entities.Reserva", b =>
                {
                    b.Property<long>("ReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ReservaID"));

                    b.Property<int>("ClasseId")
                        .HasColumnType("integer");

                    b.Property<long>("PassageiroId")
                        .HasColumnType("bigint");

                    b.Property<int>("VooId")
                        .HasColumnType("integer");

                    b.HasKey("ReservaID");

                    b.HasIndex("ClasseId");

                    b.HasIndex("PassageiroId");

                    b.HasIndex("VooId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Domain.Entities.Voo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AeroportoDestinoID")
                        .HasColumnType("bigint");

                    b.Property<long>("AeroportoOrigemID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataHoraPartida")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("PrecoTotal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("AeroportoDestinoID");

                    b.HasIndex("AeroportoOrigemID");

                    b.ToTable("Voos");
                });

            modelBuilder.Entity("Domain.Entities.Aeroporto", b =>
                {
                    b.HasOne("Domain.Entities.Cidade", "Cidade")
                        .WithMany("Aeroportos")
                        .HasForeignKey("CidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Iata", "Iata")
                        .WithMany()
                        .HasForeignKey("IataID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Iata");
                });

            modelBuilder.Entity("Domain.Entities.Bagagem", b =>
                {
                    b.HasOne("Domain.Entities.Passagem", "Passagem")
                        .WithMany()
                        .HasForeignKey("PassagemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passagem");
                });

            modelBuilder.Entity("Domain.Entities.Classe", b =>
                {
                    b.HasOne("Domain.Entities.Voo", "Voo")
                        .WithMany("Classes")
                        .HasForeignKey("VooID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.HasOne("Domain.Entities.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Passageiro", "Passageiro")
                        .WithMany()
                        .HasForeignKey("PassageiroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Voo", "Voo")
                        .WithMany()
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");

                    b.Navigation("Passageiro");

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Domain.Entities.Passagem", b =>
                {
                    b.HasOne("Domain.Entities.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Passageiro", "Passageiro")
                        .WithMany()
                        .HasForeignKey("PassageiroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Voo", "Voo")
                        .WithMany()
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");

                    b.Navigation("Compra");

                    b.Navigation("Passageiro");

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Domain.Entities.Reserva", b =>
                {
                    b.HasOne("Domain.Entities.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Passageiro", "Passageiro")
                        .WithMany()
                        .HasForeignKey("PassageiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Voo", "Voo")
                        .WithMany()
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");

                    b.Navigation("Passageiro");

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Domain.Entities.Voo", b =>
                {
                    b.HasOne("Domain.Entities.Aeroporto", "AeroportoDestino")
                        .WithMany()
                        .HasForeignKey("AeroportoDestinoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Aeroporto", "AeroportoOrigem")
                        .WithMany()
                        .HasForeignKey("AeroportoOrigemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AeroportoDestino");

                    b.Navigation("AeroportoOrigem");
                });

            modelBuilder.Entity("Domain.Entities.Cidade", b =>
                {
                    b.Navigation("Aeroportos");
                });

            modelBuilder.Entity("Domain.Entities.Voo", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}