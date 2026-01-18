using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantCuisine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cuisine",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77934829-ed97-4752-871d-245e4c520677", "AQAAAAIAAYagAAAAEFeLzIX3KXn7y4XMwWp2w57wpMfHOMyNzMD3VOtrTaTasfnAt2OQkeg1Ljn4P97Bug==", "1ee18bd8-ddad-4f0e-b4d8-91177832fa3c" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "Cuisine",
                value: "Chinese");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "Cuisine",
                value: "Thai");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "Cuisine",
                value: "Burmese");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                column: "Cuisine",
                value: "Restaurant");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 5,
                column: "Cuisine",
                value: "Fast Food");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 6,
                column: "Cuisine",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 7,
                column: "Cuisine",
                value: "Japanese");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8,
                column: "Cuisine",
                value: "Drinks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Restaurant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8d6f678-26da-4301-a8aa-ec61f8cec0a1", "AQAAAAIAAYagAAAAEKn/Aj1ntw5RyER8PkBl9gjVpdCSi7Zj3pfuqaqE9tPFcpQ0vGl5AppjzQ4t8yU/Dg==", "1f3055d9-c094-4f0a-985f-5398d4be0e29" });
        }
    }
}
