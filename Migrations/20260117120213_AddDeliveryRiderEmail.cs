using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class AddDeliveryRiderEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "DeliveryRider",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee42ac30-197d-41ba-8411-f58136e18db9", "AQAAAAIAAYagAAAAEA2FodMbcH751ajlXQiZC4/B22+vpMRVRltrn7JeVFDVCA9Z4/bcQmXvgwyPxveTxQ==", "17e6d876-a4f1-4701-9ac3-d857c23df5fc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "DeliveryRider");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95dc3c7b-c49f-4de2-a135-6f77193289c9", "AQAAAAIAAYagAAAAEK3+7YVQaE2mgYRZ+DG9f0Q0hh0YDywpKAf+wYDrAkMnBbNTXHoovEZc1UXxb6uQJQ==", "afb976d0-0a1a-4a33-9286-37dc723206aa" });
        }
    }
}
