using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.ProductAPI.Migrations
{
    public partial class NewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocalPath",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Smartphone", "The Samsung Galaxy S21 Ultra is a premium Android smartphone with a stunning 6.8-inch Dynamic AMOLED display, powerful Exynos 2100 processor, and a versatile quad-camera setup.", "https://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s21-ultra-5g-1.jpg", "Samsung Galaxy S21 Ultra", 1199.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Smartphone", "The Samsung Galaxy Z Fold 3 is a cutting-edge foldable smartphone with a large 7.6-inch Dynamic AMOLED display that folds into a compact form factor. It offers multitasking capabilities and comes with the S Pen for enhanced productivity.", "https://cdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-z-fold3-5g-2.jpg", "Samsung Galaxy Z Fold 3", 1799.99 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "Smartphone", "The Sony Xperia 1 III is a flagship Android smartphone with a stunning 6.5-inch 4K HDR OLED display, Snapdragon 888 processor, and a versatile triple-camera system. It offers pro-level photography features and audio enhancements.", "https://cdn2.gsmarena.com/vv/pics/sony/sony-xperia-1-iii-2.jpg", "Sony Xperia 1 III", 1299.99 },
                    { 8, "Smartphone", "The OnePlus Nord 2 is a mid-range Android smartphone with a powerful MediaTek Dimensity 1200 processor, 6.43-inch Fluid AMOLED display, and a capable triple-camera system. It offers flagship-like performance at an affordable price.", "https://cdn2.gsmarena.com/vv/pics/oneplus/oneplus-nord-2-5g-1.jpg", "OnePlus Nord 2", 399.99000000000001 },
                    { 9, "Smartphone", "The Xiaomi Poco F3 is a value-for-money Android smartphone with a Snapdragon 870 processor, 6.67-inch AMOLED display, and a capable triple-camera system. It offers flagship-level performance at an affordable price.", "https://cdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-poco-f3-1.jpg", "Xiaomi Poco F3", 349.99000000000001 },
                    { 10, "Smartphone", "The Google Pixel 5a is a budget-friendly Android smartphone with a Snapdragon 765G processor, 6.34-inch OLED display, and a capable dual-camera system. It offers a pure Android experience and long battery life.", "https://cdn2.gsmarena.com/vv/pics/google/google-pixel-5a-5g-2.jpg", "Google Pixel 5a", 449.99000000000001 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "ImageLocalPath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Audio Accessories", "The Apple AirPods Pro offer active noise cancellation, immersive sound, and a customizable fit for a comfortable listening experience. They come with a wireless charging case.", "https://cdn2.gsmarena.com/vv/pics/apple/apple-airpods-pro-1.jpg", "Apple AirPods Pro", 249.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Fitness Trackers", "Track your fitness goals with the Fitbit Charge 5. It monitors your heart rate, sleep quality, and provides insights into your overall health. With built-in GPS, it's perfect for tracking outdoor activities.", "https://cdn2.gsmarena.com/vv/pics/fitbit/fitbit-charge-5-1.jpg", "Fitbit Charge 5 Fitness Tracker", 179.94999999999999 });
        }
    }
}
