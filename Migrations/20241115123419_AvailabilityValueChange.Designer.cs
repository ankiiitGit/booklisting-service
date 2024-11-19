﻿// <auto-generated />
using BookListingMicroService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookListingMicroService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241115123419_AvailabilityValueChange")]
    partial class AvailabilityValueChange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookListingMicroService.Models.Book", b =>
                {
                    b.Property<long>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("bookId"));

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("availability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            bookId = 1L,
                            author = "James Clear",
                            availability = "Available",
                            bookCondition = "Good",
                            genre = "Self Help book",
                            title = "Atomic Habits"
                        },
                        new
                        {
                            bookId = 2L,
                            author = "Ayn Rand",
                            availability = "Available",
                            bookCondition = "Good",
                            genre = "Philosophical fiction",
                            title = "The Fountainhead"
                        },
                        new
                        {
                            bookId = 3L,
                            author = "Robert Kiyosaki and Sharon Lechter",
                            availability = "Available",
                            bookCondition = "Good",
                            genre = "Personal finance",
                            title = "Rich Dad Poor Dad"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
