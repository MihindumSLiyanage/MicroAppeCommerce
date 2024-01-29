using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.ProductAPI.Migrations
{
    public partial class ProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLocalPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Smartphone", "The iPhone 13 delivers powerful performance with its A15 Bionic chip and features a stunning Super Retina XDR display. It also boasts improved battery life and advanced dual-camera system.", null, "https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-2.jpg", "iPhone 13", 799.99000000000001 },
                    { 2, "Smartphone", "The Google Pixel 6 Pro offers a smooth Android experience with its Snapdragon 888 processor and features a gorgeous 6.7-inch OLED display. It also includes a powerful camera system for capturing stunning photos.", null, "https://cdn2.gsmarena.com/vv/pics/google/google-pixel-6-pro-1.jpg", "Google Pixel 6 Pro", 899.99000000000001 },
                    { 3, "Smartphone", "The OnePlus 9 Pro is a flagship Android smartphone known for its fast performance, beautiful 6.7-inch Fluid AMOLED display, and Hasselblad quad-camera system. It offers a premium experience at an affordable price.", null, "https://cdn2.gsmarena.com/vv/pics/oneplus/oneplus-9-pro-1.jpg", "OnePlus 9 Pro", 969.0 },
                    { 4, "Smartphone", "The Xiaomi Mi 11 is a feature-packed Android smartphone with a Snapdragon 888 processor and a stunning 6.81-inch AMOLED display. It also boasts a versatile triple-camera system for capturing high-quality photos and videos.", null, "https://cdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-mi11-1.jpg", "Xiaomi Mi 11", 749.0 },
                    { 5, "Audio Accessories", "The Apple AirPods Pro offer active noise cancellation, immersive sound, and a customizable fit for a comfortable listening experience. They come with a wireless charging case.", null, "https://cdn2.gsmarena.com/vv/pics/apple/apple-airpods-pro-1.jpg", "Apple AirPods Pro", 249.99000000000001 },
                    { 6, "Fitness Trackers", "Track your fitness goals with the Fitbit Charge 5. It monitors your heart rate, sleep quality, and provides insights into your overall health. With built-in GPS, it's perfect for tracking outdoor activities.", null, "https://cdn2.gsmarena.com/vv/pics/fitbit/fitbit-charge-5-1.jpg", "Fitbit Charge 5 Fitness Tracker", 179.94999999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
