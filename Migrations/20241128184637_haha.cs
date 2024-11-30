using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class haha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6405eb8a-553a-4fbf-bfbe-792fd25c1a63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff56c885-0614-4328-9721-d013011379bc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "037a73f0-6106-4189-8126-b8a4ddd8da30", null, "Admin", "ADMIN" },
                    { "43ff3d22-3a4b-47dc-9aa2-17278410d006", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "037a73f0-6106-4189-8126-b8a4ddd8da30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43ff3d22-3a4b-47dc-9aa2-17278410d006");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6405eb8a-553a-4fbf-bfbe-792fd25c1a63", null, "Admin", "ADMIN" },
                    { "ff56c885-0614-4328-9721-d013011379bc", null, "User", "USER" }
                });
        }
    }
}
