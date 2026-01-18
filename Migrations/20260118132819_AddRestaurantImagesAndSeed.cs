using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantImagesAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13e154fc-755b-4671-8b46-b6da5fff3eb4", "AQAAAAIAAYagAAAAEHWhpTxYWoZEe97RHemAL3EI14KfqcGP2L7NCkxXo34CeXcugmUOTnU+ogsmHhv7WQ==", "1b0d8b48-9b22-4ffb-8bdd-32ef42534bdb" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "images/restaurants/bangkok-bites.jpeg", 4.40m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Location", "Name", "OpeningHours" },
                values: new object[] { "images/restaurants/yangon-delight.webp", "Yishun", "Yangon Kitchen", "9:00 AM - 8:00 PM" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Location", "Name", "OpeningHours", "Rating" },
                values: new object[] { "images/restaurants/steak-grill.jpg", "Jurong", "Steak & Grill", "12:00 PM - 11:00 PM", 4.60m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name", "OpeningHours", "Rating" },
                values: new object[] { "images/restaurants/burger-hub.jpg", "Burger Hub", "10:00 AM - 12:00 AM", 4.20m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Location", "Name", "Rating" },
                values: new object[] { "images/restaurants/seoul-bbq.jpg", "City Hall", "Seoul BBQ", 4.70m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 7,
                columns: new[] { "Location", "OpeningHours" },
                values: new object[] { "Bishan", "11:00 AM - 9:30 PM" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8,
                columns: new[] { "Location", "OpeningHours", "Rating" },
                values: new object[] { "Paya Lebar", "10:00 AM - 11:00 PM", 4.80m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead2c90a-e9f6-47f2-a7b1-6bd19a6e4fb1", "AQAAAAIAAYagAAAAEN6kIrDgGkDDF0PBdzE/8oeRZ1hrGaEt219AJHWopZOTrvbaq6K8JYVgiZqR1Ynf+w==", "5c7a8c0e-a615-4380-aa80-64b17638fe97" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "images/restaurants/bangkok-bites.jpg", 4.20m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Location", "Name", "OpeningHours" },
                values: new object[] { "images/restaurants/yangon-delights.jpg", "Paya Lebar", "Yangon Delights", "10:30 AM - 9:30 PM" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Location", "Name", "OpeningHours", "Rating" },
                values: new object[] { "images/restaurants/westside-grill.jpg", "Jurong East", "Westside Grill", "12:00 PM - 10:00 PM", 4.10m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name", "OpeningHours", "Rating" },
                values: new object[] { "images/restaurants/burger-blast.jpg", "Burger Blast", "10:00 AM - 11:00 PM", 4.00m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Location", "Name", "Rating" },
                values: new object[] { "images/restaurants/seoul-kitchen.jpg", "Clementi", "Seoul Kitchen", 4.40m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 7,
                columns: new[] { "Location", "OpeningHours" },
                values: new object[] { "Bugis", "11:30 AM - 9:30 PM" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8,
                columns: new[] { "Location", "OpeningHours", "Rating" },
                values: new object[] { "Serangoon", "10:00 AM - 10:30 PM", 4.70m });
        }
    }
}
