using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class newTokens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ff8f0b8-c353-4c5a-b9f0-dc42262a9abc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d63e5617-08e1-4eed-90ea-7b6a2fd2e201");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "149ce68e-1f75-42d0-b8f1-57bde5ad1dbd", null, "Admin", "ADMIN" },
                    { "2e5ca158-fd73-4bbf-a528-34b04a5bb593", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0ff8f0b8-c353-4c5a-b9f0-dc42262a9abc", null, "Admin", "ADMIN" },
                    { "d63e5617-08e1-4eed-90ea-7b6a2fd2e201", null, "User", "USER" }
                });
        }
    }
}
