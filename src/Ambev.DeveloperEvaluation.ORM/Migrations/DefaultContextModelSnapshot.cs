﻿// <auto-generated />
using System;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("SaleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bcd13823-964d-498f-8f78-980aba3ee56f"),
                            Name = "Fone de ouvido bluetooth",
                            Price = 150m,
                            Quantity = 10,
                            SaleId = new Guid("4c032dec-2fbf-472b-8a66-9b332b289e08")
                        },
                        new
                        {
                            Id = new Guid("75bc82b9-7463-432b-9515-ad7aa58e53b1"),
                            Name = "PlayStation 5 Digital Edition",
                            Price = 4999m,
                            Quantity = 50,
                            SaleId = new Guid("4c032dec-2fbf-472b-8a66-9b332b289e08")
                        },
                        new
                        {
                            Id = new Guid("1df6f7aa-7f21-437d-a933-64040078dfe3"),
                            Name = "Smartphone Samsumg Galaxy A15",
                            Price = 2499.99m,
                            Quantity = 50,
                            SaleId = new Guid("4c032dec-2fbf-472b-8a66-9b332b289e08")
                        },
                        new
                        {
                            Id = new Guid("8557301e-2b65-4318-9f14-be00bffb0004"),
                            Name = "Joystick Dual Shock USB",
                            Price = 129.99m,
                            Quantity = 2,
                            SaleId = new Guid("afc53abe-c973-4dda-bae4-8e7a12ec4635")
                        },
                        new
                        {
                            Id = new Guid("77407f66-0e7f-4b0f-9b50-dd26aa5ba504"),
                            Name = "Warcraft III: Ultimate Edition",
                            Price = 265.34m,
                            Quantity = 20,
                            SaleId = new Guid("afc53abe-c973-4dda-bae4-8e7a12ec4635")
                        },
                        new
                        {
                            Id = new Guid("f50cf636-63a3-49af-92df-9bf274b93733"),
                            Name = "Ratchet & Clank",
                            Price = 299.99m,
                            Quantity = 5,
                            SaleId = new Guid("afc53abe-c973-4dda-bae4-8e7a12ec4635")
                        },
                        new
                        {
                            Id = new Guid("1f7b9089-cdd7-4ac7-8805-58ee3e3892f3"),
                            Name = "Notebook Dell Inspiron 1234",
                            Price = 3299.99m,
                            Quantity = 1,
                            SaleId = new Guid("afc53abe-c973-4dda-bae4-8e7a12ec4635")
                        },
                        new
                        {
                            Id = new Guid("e7d93403-7a58-4755-9e4e-e991782a3267"),
                            Name = "Smart Watch Apple",
                            Price = 1500m,
                            Quantity = 100,
                            SaleId = new Guid("db08cc4d-a1e5-4459-bf64-64395a1bb038")
                        },
                        new
                        {
                            Id = new Guid("6887a1dc-f10b-44f4-975d-41e5422521c6"),
                            Name = "The Legend of Zelda: Ocarina of Time Last Edition",
                            Price = 155.99m,
                            Quantity = 1,
                            SaleId = new Guid("db08cc4d-a1e5-4459-bf64-64395a1bb038")
                        });
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Branch")
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("SaleDate")
                        .HasColumnType("date");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalSaleAmount")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Sale", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c032dec-2fbf-472b-8a66-9b332b289e08"),
                            Branch = "Nordeste",
                            Number = 100,
                            SaleDate = new DateOnly(2024, 12, 5),
                            Status = 1,
                            TotalSaleAmount = 1255.49m
                        },
                        new
                        {
                            Id = new Guid("afc53abe-c973-4dda-bae4-8e7a12ec4635"),
                            Branch = "Norte",
                            Number = 201,
                            SaleDate = new DateOnly(2024, 10, 15),
                            Status = 1,
                            TotalSaleAmount = 355.15m
                        },
                        new
                        {
                            Id = new Guid("db08cc4d-a1e5-4459-bf64-64395a1bb038"),
                            Branch = "Sudeste",
                            Number = 300,
                            SaleDate = new DateOnly(2024, 9, 20),
                            Status = 1,
                            TotalSaleAmount = 898.37m
                        });
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Product", b =>
                {
                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.Sale", "Sale")
                        .WithMany("Products")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Sale", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
