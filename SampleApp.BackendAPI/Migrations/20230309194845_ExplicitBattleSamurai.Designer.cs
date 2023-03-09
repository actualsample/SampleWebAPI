﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleApp.BackendAPI.Data;

#nullable disable

namespace SampleApp.BackendAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230309194845_ExplicitBattleSamurai")]
    partial class ExplicitBattleSamurai
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Battle", b =>
                {
                    b.Property<int>("BattleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BattleId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BattleId");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.BattleSamurai", b =>
                {
                    b.Property<int>("BattleId")
                        .HasColumnType("int");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateJoined")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("BattleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("BattleSamurai");
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("Horse");
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SamuraiId = 1,
                            Text = "Quote from Tanjiro Kamado"
                        });
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Samurais");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kamado Tanjiro"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Muzan Kibutsuji"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Zenitsu"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Inosuke"
                        });
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.BattleSamurai", b =>
                {
                    b.HasOne("SampleApp.BackendAPI.Models.Battle", null)
                        .WithMany()
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleApp.BackendAPI.Models.Samurai", null)
                        .WithMany()
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Horse", b =>
                {
                    b.HasOne("SampleApp.BackendAPI.Models.Samurai", null)
                        .WithOne("Horse")
                        .HasForeignKey("SampleApp.BackendAPI.Models.Horse", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Quote", b =>
                {
                    b.HasOne("SampleApp.BackendAPI.Models.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("SampleApp.BackendAPI.Models.Samurai", b =>
                {
                    b.Navigation("Horse")
                        .IsRequired();

                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
