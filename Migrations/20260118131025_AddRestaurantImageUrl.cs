using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Restaurant",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead2c90a-e9f6-47f2-a7b1-6bd19a6e4fb1", "AQAAAAIAAYagAAAAEN6kIrDgGkDDF0PBdzE/8oeRZ1hrGaEt219AJHWopZOTrvbaq6K8JYVgiZqR1Ynf+w==", "5c7a8c0e-a615-4380-aa80-64b17638fe97" });

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
                value: "images/restaurants/bangkok-bites.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "ImageUrl",
                value: "images/restaurants/yangon-delights.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                column: "ImageUrl",
                value: "images/restaurants/westside-grill.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                column: "ImageUrl",
                value: "images/restaurants/burger-blast.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6,
                column: "ImageUrl",
                value: "images/restaurants/seoul-kitchen.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Restaurant");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Restaurant",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95728ebb-86a2-46ea-a83b-4b01be2d269c", "AQAAAAIAAYagAAAAEOJ5oSlaKEazhLf6GjGNUCkdzxw2Chpjvurh46WkTbndCF5K7JSENeWkCcmErhyPQQ==", "63e6e8b1-fa07-4e24-acd7-aea405029419" });
        }
    }
}
