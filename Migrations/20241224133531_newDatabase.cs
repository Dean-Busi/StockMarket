using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class newDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "149ce68e-1f75-42d0-b8f1-57bde5ad1dbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e5ca158-fd73-4bbf-a528-34b04a5bb593");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83be0e51-a141-48a1-8b1e-26ddff0d2b4b", null, "User", "USER" },
                    { "a312214f-2eb0-42f8-91c1-de13a66eda74", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83be0e51-a141-48a1-8b1e-26ddff0d2b4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a312214f-2eb0-42f8-91c1-de13a66eda74");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "149ce68e-1f75-42d0-b8f1-57bde5ad1dbd", null, "Admin", "ADMIN" },
                    { "2e5ca158-fd73-4bbf-a528-34b04a5bb593", null, "User", "USER" }
                });
        }
    }
}
