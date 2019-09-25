﻿// <auto-generated />
using System;
using Fairhr.Service.B;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fairhr.Service.B.Migrations
{
    [DbContext(typeof(WXPayInfoContext))]
    [Migration("20190925072226_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Fairhr.Service.B.PayInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<DateTime>("CrateTime");

                    b.Property<string>("Money")
                        .HasMaxLength(32);

                    b.Property<string>("OrderId")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<int>("stauts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(2)")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("PayInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
