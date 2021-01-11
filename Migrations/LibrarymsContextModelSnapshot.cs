﻿// <auto-generated />
using System;
using Libraryms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Libraryms.Migrations
{
    [DbContext(typeof(LibrarymsContext))]
    partial class LibrarymsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Libraryms.Models.Huazimi", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktiv")
                        .HasColumnType("bit");

                    b.Property<string>("DataKthimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataPritjes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Klienti_id")
                        .HasColumnType("int");

                    b.Property<int>("Libra_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Huazimi");
                });

            modelBuilder.Entity("Libraryms.Models.Klienti", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktiv")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumriTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Klientet");
                });

            modelBuilder.Entity("Libraryms.Models.Libra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("E_Lire")
                        .HasColumnType("bit");

                    b.Property<string>("Titulli")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Libra");
                });
#pragma warning restore 612, 618
        }
    }
}
