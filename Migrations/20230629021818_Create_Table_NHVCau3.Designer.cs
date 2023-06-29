﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThi_NHV.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629021818_Create_Table_NHVCau3")]
    partial class Create_Table_NHVCau3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BaiThi_NHV.Models.NHV_Cau3", b =>
                {
                    b.Property<string>("NHVMaSV")
                        .HasColumnType("TEXT");

                    b.Property<int>("NHVSDT")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NHVTenSV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NHVMaSV");

                    b.ToTable("NHV_Cau3");
                });
#pragma warning restore 612, 618
        }
    }
}