using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMenuSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95728ebb-86a2-46ea-a83b-4b01be2d269c", "AQAAAAIAAYagAAAAEOJ5oSlaKEazhLf6GjGNUCkdzxw2Chpjvurh46WkTbndCF5K7JSENeWkCcmErhyPQQ==", "63e6e8b1-fa07-4e24-acd7-aea405029419" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "RestaurantId" },
                values: new object[] { "Sweet & Sour Pork", 7.20m, 1 });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuId", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 3, "Wonton Noodles", 6.00m, 1 },
                    { 4, "Pad Thai", 6.80m, 2 },
                    { 5, "Tom Yum Soup", 7.50m, 2 },
                    { 6, "Green Curry Chicken", 8.20m, 2 },
                    { 7, "Mohinga", 5.00m, 3 },
                    { 8, "Tea Leaf Salad", 4.80m, 3 },
                    { 9, "Shan Noodles", 6.20m, 3 },
                    { 10, "Grilled Chicken Chop", 9.90m, 4 },
                    { 11, "Fish & Chips", 10.50m, 4 },
                    { 12, "Carbonara Pasta", 9.50m, 4 },
                    { 13, "Classic Beef Burger", 6.90m, 5 },
                    { 14, "Crispy Chicken Burger", 6.50m, 5 },
                    { 15, "Fries + Drink Set", 4.90m, 5 },
                    { 16, "Kimchi Fried Rice", 7.20m, 6 },
                    { 17, "Bibimbap", 8.50m, 6 },
                    { 18, "Korean Fried Chicken", 9.80m, 6 },
                    { 19, "Salmon Sushi Set", 12.50m, 7 },
                    { 20, "Chicken Katsu Don", 9.20m, 7 },
                    { 21, "Ramen (Shoyu)", 10.50m, 7 },
                    { 22, "Milk Tea (Large)", 4.50m, 8 },
                    { 23, "Matcha Latte", 5.20m, 8 },
                    { 24, "Brown Sugar Boba", 5.80m, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4c59ea-a29d-4c10-aea6-643b9d70a82d", "AQAAAAIAAYagAAAAEFHgwQdzlR2l2Db+gp0KkChHF+1vIEcWNDI1XT6uwCy4D9yLxP662iZqLBQZuZDABg==", "23c46c79-86f4-4696-9544-435040982241" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "RestaurantId" },
                values: new object[] { "Pad Thai", 6.80m, 2 });
        }
    }
}
