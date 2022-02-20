﻿// <auto-generated />
using Jachty.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jachty.Data.Migrations
{
    [DbContext(typeof(JachtyContext))]
    partial class JachtyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Jachty.Models.Jacht", b =>
                {
                    b.Property<int>("JachtID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cena")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT")
                        .HasColumnName("ImageFileName");

                    b.Property<string>("Nazwa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Opis")
                        .HasColumnType("TEXT");

                    b.Property<string>("Typ")
                        .HasColumnType("TEXT");

                    b.HasKey("JachtID");

                    b.ToTable("Jachts");

                    b.HasData(
                        new
                        {
                            JachtID = 1,
                            Cena = 400m,
                            ImageName = "bavaria30.jpg",
                            Nazwa = "Bavaria30",
                            Opis = "Lorem Ipsum...",
                            Typ = "Srodladowy"
                        },
                        new
                        {
                            JachtID = 2,
                            Cena = 500m,
                            ImageName = "bavaria31.jpg",
                            Nazwa = "Bavaria31",
                            Opis = "Lorem Ipsum...",
                            Typ = "Srodladowy"
                        },
                        new
                        {
                            JachtID = 3,
                            Cena = 600m,
                            ImageName = "bavaria32.jpg",
                            Nazwa = "Bavaria32",
                            Opis = "Lorem Ipsum...",
                            Typ = "Srodladowy"
                        },
                        new
                        {
                            JachtID = 4,
                            Cena = 800m,
                            ImageName = "bavaria50.jpg",
                            Nazwa = "Bavaria50",
                            Opis = "Lorem Ipsum...",
                            Typ = "Morski"
                        },
                        new
                        {
                            JachtID = 5,
                            Cena = 1000m,
                            ImageName = "bavaria51.jpg",
                            Nazwa = "Bavaria51",
                            Opis = "Lorem Ipsum...",
                            Typ = "Morski"
                        },
                        new
                        {
                            JachtID = 6,
                            Cena = 1200m,
                            ImageName = "bavaria55.jpg",
                            Nazwa = "Bavaria55",
                            Opis = "Lorem Ipsum...",
                            Typ = "Morski"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}