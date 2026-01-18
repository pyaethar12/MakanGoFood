using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRestaurantCuisineSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65de166d-17ce-4c0f-ae36-477a31a2def8", "AQAAAAIAAYagAAAAELDc56PBb3v/CBewgrF1lA3JeaeWCwo54lszDFbvlQZljfSZEGwNr/j6N2ObgY/xpg==", "2d6d057e-9b50-4ab9-84ae-9b7f96c2b39f" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                column: "Cuisine",
                value: "Western");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77934829-ed97-4752-871d-245e4c520677", "AQAAAAIAAYagAAAAEFeLzIX3KXn7y4XMwWp2w57wpMfHOMyNzMD3VOtrTaTasfnAt2OQkeg1Ljn4P97Bug==", "1ee18bd8-ddad-4f0e-b4d8-91177832fa3c" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 4,
                column: "Cuisine",
                value: "Restaurant");
        }
    }
}
