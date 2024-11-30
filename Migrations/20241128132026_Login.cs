using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7b5cc69-186c-4cba-9680-efbb0f344828");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d984c1e8-d554-4c68-be0b-c32dd3e28f9f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15e0bca1-9cc2-4830-b834-f7c2111f93da", null, "Admin", "ADMIN" },
                    { "9811330f-35ab-4fd8-8fb7-30b6fe27f66e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e0bca1-9cc2-4830-b834-f7c2111f93da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9811330f-35ab-4fd8-8fb7-30b6fe27f66e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d7b5cc69-186c-4cba-9680-efbb0f344828", null, "User", "USER" },
                    { "d984c1e8-d554-4c68-be0b-c32dd3e28f9f", null, "Admin", "ADMIN" }
                });
        }
    }
}
