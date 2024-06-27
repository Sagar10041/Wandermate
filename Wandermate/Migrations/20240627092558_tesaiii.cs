using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class tesaiii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b46e097-cb30-499d-b78e-8afb904ff7af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98655d7-6e96-44f0-a76b-b6e96e178392");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bf7fa1b-5f78-467c-b849-93839f611e99", null, "Admin", "ADMIN" },
                    { "bf27aaa5-23f0-4087-ae43-ee7c986204cf", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bf7fa1b-5f78-467c-b849-93839f611e99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf27aaa5-23f0-4087-ae43-ee7c986204cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b46e097-cb30-499d-b78e-8afb904ff7af", null, "User", "USER" },
                    { "f98655d7-6e96-44f0-a76b-b6e96e178392", null, "Admin", "ADMIN" }
                });
        }
    }
}
