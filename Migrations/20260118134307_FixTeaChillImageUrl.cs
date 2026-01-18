using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class FixTeaChillImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8d6f678-26da-4301-a8aa-ec61f8cec0a1", "AQAAAAIAAYagAAAAEKn/Aj1ntw5RyER8PkBl9gjVpdCSi7Zj3pfuqaqE9tPFcpQ0vGl5AppjzQ4t8yU/Dg==", "1f3055d9-c094-4f0a-985f-5398d4be0e29" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/restaurants/tea-chill.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/restaurants/tea-chill.jpg");
        }
    }
}
