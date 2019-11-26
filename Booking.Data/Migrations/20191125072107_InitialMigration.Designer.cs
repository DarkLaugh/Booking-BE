﻿// <auto-generated />
using Booking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Booking.Data.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20191125072107_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Booking.Data.Models.Client", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<byte>("ClientTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientTypeId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Booking.Data.Models.ClientType", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientTypes");
                });

            modelBuilder.Entity("Booking.Data.Models.Resort", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Capacity")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<byte>("ResortTypeId")
                        .HasColumnType("tinyint");

                    b.Property<short>("Rooms")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("ResortTypeId");

                    b.ToTable("Resorts");
                });

            modelBuilder.Entity("Booking.Data.Models.ResortType", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("ResortTypes");
                });

            modelBuilder.Entity("Booking.Data.Models.Client", b =>
                {
                    b.HasOne("Booking.Data.Models.ClientType", "ClientType")
                        .WithMany()
                        .HasForeignKey("ClientTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Booking.Data.Models.Resort", b =>
                {
                    b.HasOne("Booking.Data.Models.ResortType", "Type")
                        .WithMany()
                        .HasForeignKey("ResortTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
