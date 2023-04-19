﻿// <auto-generated />
using System;
using AcceleratorLinq.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcceleratorLinq.Data.Migrations
{
    [DbContext(typeof(BusinessesContext))]
    partial class BusinessesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("AcceleratorLinq.Data.Entities.Business", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("AcceleratorLinq.Data.Entities.Shareholder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmountOfShares")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("BusinessId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Shareholders");
                });

            modelBuilder.Entity("AcceleratorLinq.Data.Entities.Shareholder", b =>
                {
                    b.HasOne("AcceleratorLinq.Data.Entities.Business", null)
                        .WithMany("Shareholders")
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("AcceleratorLinq.Data.Entities.Business", b =>
                {
                    b.Navigation("Shareholders");
                });
#pragma warning restore 612, 618
        }
    }
}
