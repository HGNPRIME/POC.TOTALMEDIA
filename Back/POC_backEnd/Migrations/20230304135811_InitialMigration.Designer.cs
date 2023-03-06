﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POC_backEnd.Context;

#nullable disable

namespace POC_backEnd.Migrations
{
    [DbContext(typeof(PocTotalMediaContext))]
    [Migration("20230304135811_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("POC_backEnd.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CountryName");

                    b.HasKey("CountryId");

                    b.ToTable("country", (string)null);

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "United Kingdom"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Portugal"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Spain"
                        });
                });

            modelBuilder.Entity("POC_backEnd.Models.VatRate", b =>
                {
                    b.Property<int>("VatRateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VatRateId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VatRateId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("CountryId");

                    b.Property<decimal>("VatNumber")
                        .HasColumnType("decimal(5,3)")
                        .HasColumnName("VatNumber");

                    b.HasKey("VatRateId")
                        .HasName("PK_VatRates");

                    b.HasIndex("CountryId");

                    b.ToTable("vatrates", (string)null);

                    b.HasData(
                        new
                        {
                            VatRateId = 1,
                            CountryId = 1,
                            VatNumber = 5.5m
                        },
                        new
                        {
                            VatRateId = 2,
                            CountryId = 1,
                            VatNumber = 20m
                        },
                        new
                        {
                            VatRateId = 3,
                            CountryId = 1,
                            VatNumber = 10m
                        },
                        new
                        {
                            VatRateId = 4,
                            CountryId = 2,
                            VatNumber = 5m
                        },
                        new
                        {
                            VatRateId = 5,
                            CountryId = 2,
                            VatNumber = 20m
                        },
                        new
                        {
                            VatRateId = 6,
                            CountryId = 3,
                            VatNumber = 6m
                        },
                        new
                        {
                            VatRateId = 7,
                            CountryId = 3,
                            VatNumber = 13m
                        },
                        new
                        {
                            VatRateId = 8,
                            CountryId = 3,
                            VatNumber = 23m
                        },
                        new
                        {
                            VatRateId = 9,
                            CountryId = 4,
                            VatNumber = 21m
                        },
                        new
                        {
                            VatRateId = 10,
                            CountryId = 4,
                            VatNumber = 10m
                        });
                });

            modelBuilder.Entity("POC_backEnd.Models.VatRate", b =>
                {
                    b.HasOne("POC_backEnd.Models.Country", "Country")
                        .WithMany("VatRates")
                        .HasForeignKey("CountryId")
                        .IsRequired()
                        .HasConstraintName("FK_vatRates_country");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("POC_backEnd.Models.Country", b =>
                {
                    b.Navigation("VatRates");
                });
#pragma warning restore 612, 618
        }
    }
}