﻿// <auto-generated />
using System;
using Ecommerce.Infrastructure.Presistence.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Option", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "Id");

                    b.ToTable("OPTIONS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Size"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Brand"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Color"
                        });
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.OptionValues", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdOption")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IdOption", "Id", "Value");

                    b.ToTable("OPTION_VALUES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IdOption = 1L,
                            Value = "M"
                        },
                        new
                        {
                            Id = 2L,
                            IdOption = 1L,
                            Value = "L"
                        },
                        new
                        {
                            Id = 3L,
                            IdOption = 1L,
                            Value = "XL"
                        },
                        new
                        {
                            Id = 4L,
                            IdOption = 1L,
                            Value = "XXL"
                        },
                        new
                        {
                            Id = 5L,
                            IdOption = 1L,
                            Value = "S"
                        },
                        new
                        {
                            Id = 6L,
                            IdOption = 3L,
                            Value = "Red"
                        },
                        new
                        {
                            Id = 7L,
                            IdOption = 1L,
                            Value = "Green"
                        },
                        new
                        {
                            Id = 8L,
                            IdOption = 1L,
                            Value = "Blue"
                        });
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Products", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductName", "Id");

                    b.ToTable("PRODUCTS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ProductName = "Áo Adidaphat"
                        },
                        new
                        {
                            Id = 2L,
                            ProductName = "Quần Adidalat"
                        });
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.VariantDetail", b =>
                {
                    b.Property<long>("IdVariant")
                        .HasColumnType("bigint");

                    b.Property<long>("IdOption")
                        .HasColumnType("bigint");

                    b.Property<long>("IdValue")
                        .HasColumnType("bigint");

                    b.HasKey("IdVariant", "IdOption", "IdValue");

                    b.HasIndex("IdOption");

                    b.HasIndex("IdValue");

                    b.HasIndex("IdVariant", "IdOption", "IdValue");

                    b.ToTable("VARIANT_DETAILS", (string)null);

                    b.HasData(
                        new
                        {
                            IdVariant = 1L,
                            IdOption = 1L,
                            IdValue = 4L
                        },
                        new
                        {
                            IdVariant = 1L,
                            IdOption = 3L,
                            IdValue = 6L
                        },
                        new
                        {
                            IdVariant = 2L,
                            IdOption = 1L,
                            IdValue = 3L
                        },
                        new
                        {
                            IdVariant = 2L,
                            IdOption = 3L,
                            IdValue = 6L
                        },
                        new
                        {
                            IdVariant = 3L,
                            IdOption = 1L,
                            IdValue = 2L
                        },
                        new
                        {
                            IdVariant = 3L,
                            IdOption = 3L,
                            IdValue = 7L
                        });
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Variants", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdProduct")
                        .HasColumnType("bigint");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("VariantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdProduct", "Id");

                    b.ToTable("VARIANTS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IdProduct = 1L,
                            Price = 100000m,
                            Quantity = 28,
                            VariantName = "NK_XXL_RED"
                        },
                        new
                        {
                            Id = 2L,
                            IdProduct = 1L,
                            Price = 900000m,
                            Quantity = 2,
                            VariantName = "NK_XL_RED"
                        },
                        new
                        {
                            Id = 3L,
                            IdProduct = 1L,
                            Price = 900000m,
                            Quantity = 2,
                            VariantName = "NK_L_GRE"
                        });
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.OptionValues", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Products.Option", "IdOptionNavigation")
                        .WithMany("OptionsValues")
                        .HasForeignKey("IdOption")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IdOptionNavigation");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.VariantDetail", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Products.Option", "IdOptionNavigation")
                        .WithMany("VariantDetails")
                        .HasForeignKey("IdOption")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ecommerce.Domain.Entities.Products.OptionValues", "IdValueNavigation")
                        .WithMany("VariantDetails")
                        .HasForeignKey("IdValue")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ecommerce.Domain.Entities.Products.Variants", "IdVariantNavigation")
                        .WithMany("VariantDetails")
                        .HasForeignKey("IdVariant")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IdOptionNavigation");

                    b.Navigation("IdValueNavigation");

                    b.Navigation("IdVariantNavigation");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Variants", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Products.Products", "IdProductNavigation")
                        .WithMany("Variants")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Option", b =>
                {
                    b.Navigation("OptionsValues");

                    b.Navigation("VariantDetails");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.OptionValues", b =>
                {
                    b.Navigation("VariantDetails");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Products", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Products.Variants", b =>
                {
                    b.Navigation("VariantDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
