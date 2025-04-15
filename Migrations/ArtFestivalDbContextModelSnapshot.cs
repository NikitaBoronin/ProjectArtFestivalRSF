﻿// <auto-generated />
using System;
using ArtFestival;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArtFestival.Migrations
{
    [DbContext(typeof(ArtFestivalDbContext))]
    partial class ArtFestivalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ArtFestival.Model.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EventID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("bytea");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EventID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ArtFestival.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Name = "Алмаз"
                        },
                        new
                        {
                            UserID = 2,
                            Name = "Олег"
                        },
                        new
                        {
                            UserID = 3,
                            Name = "Иван Иванов"
                        },
                        new
                        {
                            UserID = 4,
                            Name = "Айназ"
                        },
                        new
                        {
                            UserID = 5,
                            Name = "Никита"
                        });
                });

            modelBuilder.Entity("EventUser", b =>
                {
                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("EventID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("EventUsers");
                });

            modelBuilder.Entity("EventUser", b =>
                {
                    b.HasOne("ArtFestival.Model.Event", null)
                        .WithMany("Users")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtFestival.Model.User", null)
                        .WithMany("Events")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArtFestival.Model.Event", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ArtFestival.Model.User", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
