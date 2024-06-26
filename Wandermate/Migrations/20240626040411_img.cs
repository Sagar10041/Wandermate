using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class img : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad8c8670-3eb9-4ee8-964a-12d860b44c52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7491a98-7874-46c3-ae51-1c22f4b6c38f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37f62137-b5de-4e80-b40f-879cabf2f2ff", null, "Admin", "ADMIN" },
                    { "584e9cd5-b2a1-43ca-997c-2895bb526b70", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37f62137-b5de-4e80-b40f-879cabf2f2ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "584e9cd5-b2a1-43ca-997c-2895bb526b70");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad8c8670-3eb9-4ee8-964a-12d860b44c52", null, "User", "USER" },
                    { "e7491a98-7874-46c3-ae51-1c22f4b6c38f", null, "Admin", "ADMIN" }
                });
        }
    }
}
