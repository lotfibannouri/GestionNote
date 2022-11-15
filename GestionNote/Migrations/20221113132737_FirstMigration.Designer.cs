﻿// <auto-generated />
using GestionNote.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionNote.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221113132737_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionNote.Models.Etudiant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Etudiant");
                });

            modelBuilder.Entity("GestionNote.Models.Matieres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Coef")
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Matieres");
                });

            modelBuilder.Entity("GestionNote.Models.Notes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDEtudiant")
                        .HasColumnType("int");

                    b.Property<int>("IDMatieres")
                        .HasColumnType("int");

                    b.Property<int>("matieresID")
                        .HasColumnType("int");

                    b.Property<double>("note")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("IDEtudiant");

                    b.HasIndex("matieresID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("GestionNote.Models.Notes", b =>
                {
                    b.HasOne("GestionNote.Models.Etudiant", "Etudiant")
                        .WithMany("notes")
                        .HasForeignKey("IDEtudiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionNote.Models.Matieres", "matieres")
                        .WithMany("notes")
                        .HasForeignKey("matieresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etudiant");

                    b.Navigation("matieres");
                });

            modelBuilder.Entity("GestionNote.Models.Etudiant", b =>
                {
                    b.Navigation("notes");
                });

            modelBuilder.Entity("GestionNote.Models.Matieres", b =>
                {
                    b.Navigation("notes");
                });
#pragma warning restore 612, 618
        }
    }
}
