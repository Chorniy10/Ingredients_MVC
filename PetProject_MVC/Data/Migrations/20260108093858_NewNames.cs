using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject_MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious beef pizza", "Beef pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious chicken pizza", "Chicken pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious fish pizza", "Fish pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious beef taco", "Beef Taco" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious chicken taco", "Chicken Taco" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious beef taco", "Fish Taco" });
        }
    }
}
