using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class TokenService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af4f079-00f8-48e2-be6e-ac23123433bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eff314b1-94b9-4ef2-a2e8-8e31ad3fdd25");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d7b5cc69-186c-4cba-9680-efbb0f344828", null, "User", "USER" },
                    { "d984c1e8-d554-4c68-be0b-c32dd3e28f9f", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "8af4f079-00f8-48e2-be6e-ac23123433bd", null, "Admin", "ADMIN" },
                    { "eff314b1-94b9-4ef2-a2e8-8e31ad3fdd25", null, "User", "USER" }
                });
        }
    }
}
