using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef1cd15f-28ae-4eb3-b78c-88bd323fb6e1", "AQAAAAIAAYagAAAAEB1Lfrym/cb+ozauzUGF7yaAEah3IqrXD7SE5n6fBxJe8Z6he6kQtvnqnSVAiKWWIg==", "51d41e90-6174-4c49-a67c-0b89616b7bbc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c8145b0-924b-485a-89dd-4a716c984edd", "AQAAAAIAAYagAAAAEH5rgIW3qx4aIwX8oNuLvHZnk871zG2GvHWBWWavrJWh9fwCHJcDKrea1W/Td1l/uQ==", "d946c4b7-f9e3-4e89-a06f-4bde69e4546a" });
        }
    }
}
