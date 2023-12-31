﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SarahBdayApi.Models;

#nullable disable

namespace SarahBdayApi.Migrations
{
    [DbContext(typeof(SarahBdayApiContext))]
    [Migration("20230719204222_FixTypo")]
    partial class FixTypo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SarahBdayApi.Models.Attendant", b =>
                {
                    b.Property<int>("AttendantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DoYouBelieve")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("AttendantId");

                    b.ToTable("Attendants");
                });
#pragma warning restore 612, 618
        }
    }
}
