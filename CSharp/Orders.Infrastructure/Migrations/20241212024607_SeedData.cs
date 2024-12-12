using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orders.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: ["Id", "Name"],
                values: new object[,] { { 1, "Alice" }, { 2, "Bob" } });
            migrationBuilder.InsertData(
                table: "Orders",
                columns: ["Id", "CustomerId", "CreatedDate", "LastUpdatedDate", "Status", "Total"],
                values: new object[,] { { 1, 1, DateTime.Now, DateTime.Now, 1, 100.00m }, { 2, 2, DateTime.Now, DateTime.Now, 1, 200.00m } });
            migrationBuilder.InsertData(
                table: "Items",
                columns: ["Id", "Name", "Price"],
                values: new object[,] { { 1, "Item1", 50.00m }, { 2, "Item2", 50.00m }, { 3, "Item3", 100.00m } });
            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: ["OrderId", "ItemId"],
                values: new object[,] { { 1, 1 }, { 1, 2 }, { 2, 3 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
