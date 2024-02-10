using Microsoft.EntityFrameworkCore;
using Services.ProductAPI.Models;

namespace Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "iPhone 13",
                Price = 799.99,
                Description = "The iPhone 13 delivers powerful performance with its A15 Bionic chip and features a stunning Super Retina XDR display. It also boasts improved battery life and advanced dual-camera system.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-2.jpg",
                CategoryName = "Smartphone"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Google Pixel 6 Pro",
                Price = 899.99,
                Description = "The Google Pixel 6 Pro offers a smooth Android experience with its Snapdragon 888 processor and features a gorgeous 6.7-inch OLED display. It also includes a powerful camera system for capturing stunning photos.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/google/google-pixel-6-pro-1.jpg",
                CategoryName = "Smartphone"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "OnePlus 9 Pro",
                Price = 969.00,
                Description = "The OnePlus 9 Pro is a flagship Android smartphone known for its fast performance, beautiful 6.7-inch Fluid AMOLED display, and Hasselblad quad-camera system. It offers a premium experience at an affordable price.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/oneplus/oneplus-9-pro-1.jpg",
                CategoryName = "Smartphone"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Xiaomi Mi 11",
                Price = 749.00,
                Description = "The Xiaomi Mi 11 is a feature-packed Android smartphone with a Snapdragon 888 processor and a stunning 6.81-inch AMOLED display. It also boasts a versatile triple-camera system for capturing high-quality photos and videos.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-mi11-1.jpg",
                CategoryName = "Smartphone"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "OnePlus Nord 2",
                Price = 399.99,
                Description = "The OnePlus Nord 2 is a mid-range Android smartphone with a powerful MediaTek Dimensity 1200 processor, 6.43-inch Fluid AMOLED display, and a capable triple-camera system. It offers flagship-like performance at an affordable price.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/oneplus/oneplus-nord-2-5g-1.jpg",
                CategoryName = "Smartphone"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Xiaomi Poco F3",
                Price = 349.99,
                Description = "The Xiaomi Poco F3 is a value-for-money Android smartphone with a Snapdragon 870 processor, 6.67-inch AMOLED display, and a capable triple-camera system. It offers flagship-level performance at an affordable price.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-poco-f3-1.jpg",
                CategoryName = "Smartphone"
            });
        }
    }
}
