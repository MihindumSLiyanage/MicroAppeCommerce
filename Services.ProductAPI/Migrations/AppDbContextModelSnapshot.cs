﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services.ProductAPI.Data;

#nullable disable

namespace Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Smartphone",
                            Description = "The iPhone 13 delivers powerful performance with its A15 Bionic chip and features a stunning Super Retina XDR display. It also boasts improved battery life and advanced dual-camera system.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-2.jpg",
                            Name = "iPhone 13",
                            Price = 799.99000000000001
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Smartphone",
                            Description = "The Google Pixel 6 Pro offers a smooth Android experience with its Snapdragon 888 processor and features a gorgeous 6.7-inch OLED display. It also includes a powerful camera system for capturing stunning photos.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/google/google-pixel-6-pro-1.jpg",
                            Name = "Google Pixel 6 Pro",
                            Price = 899.99000000000001
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Smartphone",
                            Description = "The OnePlus 9 Pro is a flagship Android smartphone known for its fast performance, beautiful 6.7-inch Fluid AMOLED display, and Hasselblad quad-camera system. It offers a premium experience at an affordable price.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/oneplus/oneplus-9-pro-1.jpg",
                            Name = "OnePlus 9 Pro",
                            Price = 969.0
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Smartphone",
                            Description = "The Xiaomi Mi 11 is a feature-packed Android smartphone with a Snapdragon 888 processor and a stunning 6.81-inch AMOLED display. It also boasts a versatile triple-camera system for capturing high-quality photos and videos.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-mi11-1.jpg",
                            Name = "Xiaomi Mi 11",
                            Price = 749.0
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryName = "Smartphone",
                            Description = "The Samsung Galaxy S21 Ultra is a premium Android smartphone with a stunning 6.8-inch Dynamic AMOLED display, powerful Exynos 2100 processor, and a versatile quad-camera setup.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s21-ultra-5g-1.jpg",
                            Name = "Samsung Galaxy S21 Ultra",
                            Price = 1199.99
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryName = "Smartphone",
                            Description = "The Samsung Galaxy Z Fold 3 is a cutting-edge foldable smartphone with a large 7.6-inch Dynamic AMOLED display that folds into a compact form factor. It offers multitasking capabilities and comes with the S Pen for enhanced productivity.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-z-fold3-5g-2.jpg",
                            Name = "Samsung Galaxy Z Fold 3",
                            Price = 1799.99
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryName = "Smartphone",
                            Description = "The Sony Xperia 1 III is a flagship Android smartphone with a stunning 6.5-inch 4K HDR OLED display, Snapdragon 888 processor, and a versatile triple-camera system. It offers pro-level photography features and audio enhancements.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/sony/sony-xperia-1-iii-2.jpg",
                            Name = "Sony Xperia 1 III",
                            Price = 1299.99
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryName = "Smartphone",
                            Description = "The OnePlus Nord 2 is a mid-range Android smartphone with a powerful MediaTek Dimensity 1200 processor, 6.43-inch Fluid AMOLED display, and a capable triple-camera system. It offers flagship-like performance at an affordable price.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/oneplus/oneplus-nord-2-5g-1.jpg",
                            Name = "OnePlus Nord 2",
                            Price = 399.99000000000001
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryName = "Smartphone",
                            Description = "The Xiaomi Poco F3 is a value-for-money Android smartphone with a Snapdragon 870 processor, 6.67-inch AMOLED display, and a capable triple-camera system. It offers flagship-level performance at an affordable price.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-poco-f3-1.jpg",
                            Name = "Xiaomi Poco F3",
                            Price = 349.99000000000001
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryName = "Smartphone",
                            Description = "The Google Pixel 5a is a budget-friendly Android smartphone with a Snapdragon 765G processor, 6.34-inch OLED display, and a capable dual-camera system. It offers a pure Android experience and long battery life.",
                            ImageUrl = "https://cdn2.gsmarena.com/vv/pics/google/google-pixel-5a-5g-2.jpg",
                            Name = "Google Pixel 5a",
                            Price = 449.99000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
