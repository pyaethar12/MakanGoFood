using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class FixRestaurantImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7310549d-d6be-4eaf-8acf-1695089b7e98", "AQAAAAIAAYagAAAAEOCk72gKlBDOk9CFTrkxW9Ln1s/uukbfA41mgJqRWiRDRvmGyRNjK/h6rmBfl8ZoeA==", "09c5c755-0873-4e2d-a70b-f444c63db08a" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/restaurants/golden-dragon.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/restaurants/bangkok-bites.jpeg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/restaurants/yangon-delight.webp");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/restaurants/steak-grill.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/restaurants/burger-hub.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/restaurants/seoul-bbq.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/restaurants/sakura-sushi.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/restaurants/tea-chill.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "ImageUrl",
                value: "images/restaurants/golden-dragon.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "ImageUrl",
                value: "images/restaurants/bangkok-bites.jpeg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "ImageUrl",
                value: "images/restaurants/yangon-delight.webp");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                column: "ImageUrl",
                value: "images/restaurants/steak-grill.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                column: "ImageUrl",
                value: "images/restaurants/burger-hub.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6,
                column: "ImageUrl",
                value: "images/restaurants/seoul-bbq.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 7,
                column: "ImageUrl",
                value: "images/restaurants/sakura-sushi.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8,
                column: "ImageUrl",
                value: "images/restaurants/tea-chill.jpg");
        }
    }
}
