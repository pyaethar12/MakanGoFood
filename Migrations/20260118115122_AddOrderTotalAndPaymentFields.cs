using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakanGoFood.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderTotalAndPaymentFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payment_OrderId",
                table: "Payment");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidAt",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionRef",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Order",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e42f0d9-4f05-490a-8f01-8f5f7dd72a45", "AQAAAAIAAYagAAAAEKfuLxEGcpHQgmgXI2rd+9cK1oPgpfhG2h1+/70/tIHo5/fWfb3EDA63dYJkrde9MQ==", "e6cceddf-022a-4cf0-a604-c08bb709d4f8" });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payment_OrderId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaidAt",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "TransactionRef",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef1cd15f-28ae-4eb3-b78c-88bd323fb6e1", "AQAAAAIAAYagAAAAEB1Lfrym/cb+ozauzUGF7yaAEah3IqrXD7SE5n6fBxJe8Z6he6kQtvnqnSVAiKWWIg==", "51d41e90-6174-4c49-a67c-0b89616b7bbc" });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");
        }
    }
}
