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
                Name = "Apple AirPods Pro",
                Price = 249.99,
                Description = "The Apple AirPods Pro offer active noise cancellation, immersive sound, and a customizable fit for a comfortable listening experience. They come with a wireless charging case.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/apple/apple-airpods-pro-1.jpg",
                CategoryName = "Audio Accessories"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Fitbit Charge 5 Fitness Tracker",
                Price = 179.95,
                Description = "Track your fitness goals with the Fitbit Charge 5. It monitors your heart rate, sleep quality, and provides insights into your overall health. With built-in GPS, it's perfect for tracking outdoor activities.",
                ImageUrl = "https://cdn2.gsmarena.com/vv/pics/fitbit/fitbit-charge-5-1.jpg",
                CategoryName = "Fitness Trackers"
            });
        }
    }
}
