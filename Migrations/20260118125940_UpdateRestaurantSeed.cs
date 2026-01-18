using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRestaurantSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4c59ea-a29d-4c10-aea6-643b9d70a82d", "AQAAAAIAAYagAAAAEFHgwQdzlR2l2Db+gp0KkChHF+1vIEcWNDI1XT6uwCy4D9yLxP662iZqLBQZuZDABg==", "23c46c79-86f4-4696-9544-435040982241" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "OpeningHours",
                value: "10:00 AM - 10:00 PM");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "OpeningHours",
                value: "11:00 AM - 9:00 PM");

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "Location", "Name", "OpeningHours", "Rating" },
                values: new object[,]
                {
                    { 3, "Paya Lebar", "Yangon Delights", "10:30 AM - 9:30 PM", 4.30m },
                    { 4, "Jurong East", "Westside Grill", "12:00 PM - 10:00 PM", 4.10m },
                    { 5, "Woodlands", "Burger Blast", "10:00 AM - 11:00 PM", 4.00m },
                    { 6, "Clementi", "Seoul Kitchen", "11:00 AM - 10:00 PM", 4.40m },
                    { 7, "Bugis", "Sakura Sushi", "11:30 AM - 9:30 PM", 4.60m },
                    { 8, "Serangoon", "Tea & Chill", "10:00 AM - 10:30 PM", 4.70m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e42f0d9-4f05-490a-8f01-8f5f7dd72a45", "AQAAAAIAAYagAAAAEKfuLxEGcpHQgmgXI2rd+9cK1oPgpfhG2h1+/70/tIHo5/fWfb3EDA63dYJkrde9MQ==", "e6cceddf-022a-4cf0-a604-c08bb709d4f8" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "OpeningHours",
                value: "10am - 10pm");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "OpeningHours",
                value: "11am - 9pm");
        }
    }
}
