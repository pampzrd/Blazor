﻿// <auto-generated />
using System;
using DevotionNote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevotionNote.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250611053743_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DevotionNote.Models.Anotacoes", b =>
                {
                    b.Property<int>("AnotacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnotacaoId"));

                    b.Property<string>("Anotacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnotacaoId");

                    b.ToTable("Anotacao");
                });

            modelBuilder.Entity("DevotionNote.Models.Versiculos", b =>
                {
                    b.Property<int>("IdVersiculos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVersiculos"));

                    b.Property<int>("AnotacoesAnotacaoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataDeInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Versiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("palavrasChave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVersiculos");

                    b.HasIndex("AnotacoesAnotacaoId");

                    b.ToTable("Versiculo");
                });

            modelBuilder.Entity("DevotionNote.Models.Versiculos", b =>
                {
                    b.HasOne("DevotionNote.Models.Anotacoes", "Anotacoes")
                        .WithMany()
                        .HasForeignKey("AnotacoesAnotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anotacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
