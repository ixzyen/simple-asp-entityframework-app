﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sklep.encje;

namespace sklep.Migrations
{
    [DbContext(typeof(SklepContext))]
    [Migration("20200513161525_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sklep.encje.klient", b =>
                {
                    b.Property<int>("KlientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KlientId");

                    b.ToTable("klienci");
                });

            modelBuilder.Entity("sklep.encje.produkt", b =>
                {
                    b.Property<int>("ProduktId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProduktId");

                    b.ToTable("produkty");
                });

            modelBuilder.Entity("sklep.encje.zamowienie", b =>
                {
                    b.Property<int>("ZamowienieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KlientFK")
                        .HasColumnType("int");

                    b.Property<int>("ProduktFK")
                        .HasColumnType("int");

                    b.HasKey("ZamowienieId");

                    b.HasIndex("KlientFK");

                    b.HasIndex("ProduktFK")
                        .IsUnique();

                    b.ToTable("zamowienia");
                });

            modelBuilder.Entity("sklep.encje.zamowienie", b =>
                {
                    b.HasOne("sklep.encje.klient", "Klient")
                        .WithMany("zamowienia")
                        .HasForeignKey("KlientFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sklep.encje.produkt", "produkt")
                        .WithOne("zamowienie")
                        .HasForeignKey("sklep.encje.zamowienie", "ProduktFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
