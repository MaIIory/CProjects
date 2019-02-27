﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TankRentals.Models;

namespace TankRentals.Migrations
{
    [DbContext(typeof(TanksContext))]
    [Migration("20190121215609_Add MemrhTp")]
    partial class AddMemrhTp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TankRentals.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<bool>("IsSubscribedToNewsletter");

                    b.Property<int?>("MembershipTypeId1");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TankRentals.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Contract");

                    b.Property<int>("ContractDurationInMonths");

                    b.Property<float>("DiscountLevel");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");
                });

            modelBuilder.Entity("TankRentals.Models.Tank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Model");

                    b.Property<short>("NumberInGarage");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<byte?>("TankTypeId");

                    b.HasKey("Id");

                    b.HasIndex("TankTypeId");

                    b.ToTable("Tanks");
                });

            modelBuilder.Entity("TankRentals.Models.TankType", b =>
                {
                    b.Property<byte>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TankType");
                });

            modelBuilder.Entity("TankRentals.Models.Customer", b =>
                {
                    b.HasOne("TankRentals.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId1");
                });

            modelBuilder.Entity("TankRentals.Models.Tank", b =>
                {
                    b.HasOne("TankRentals.Models.TankType", "TankType")
                        .WithMany()
                        .HasForeignKey("TankTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
