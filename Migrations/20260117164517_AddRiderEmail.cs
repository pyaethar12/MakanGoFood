using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class AddRiderEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c8145b0-924b-485a-89dd-4a716c984edd", "AQAAAAIAAYagAAAAEH5rgIW3qx4aIwX8oNuLvHZnk871zG2GvHWBWWavrJWh9fwCHJcDKrea1W/Td1l/uQ==", "d946c4b7-f9e3-4e89-a06f-4bde69e4546a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee42ac30-197d-41ba-8411-f58136e18db9", "AQAAAAIAAYagAAAAEA2FodMbcH751ajlXQiZC4/B22+vpMRVRltrn7JeVFDVCA9Z4/bcQmXvgwyPxveTxQ==", "17e6d876-a4f1-4701-9ac3-d857c23df5fc" });
        }
    }
}
