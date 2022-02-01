﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission4.Models;

namespace mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220201040444_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission4.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryType")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryType = "Romance/Fantasy"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryType = "Comedy/Adventure"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryType = "Rom-com"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryType = "Horror"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryType = "Action"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryType = "Mystery"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryType = "Drama"
                        });
                });

            modelBuilder.Entity("mission4.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryID = 1,
                            Director = "Richard Curtis",
                            Edited = true,
                            Notes = "Live your life",
                            Rating = "R",
                            Title = "About Time",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryID = 2,
                            Director = "Ben Stiller",
                            Edited = true,
                            Notes = "Start Living",
                            Rating = "PG",
                            Title = "The Secret Life of Walter Mitty",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryID = 3,
                            Director = "Christian Ditter",
                            Edited = false,
                            Notes = "Fight for Love",
                            Rating = "R",
                            Title = "Love, Rosie",
                            Year = 2014
                        });
                });

            modelBuilder.Entity("mission4.Models.MovieResponse", b =>
                {
                    b.HasOne("mission4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}