using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b5d4833-f5e9-4f20-b182-f4fc7cb226b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f3e775e-72f7-43e0-84db-509111286d4c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e45d2fb-807f-47b2-902b-e2dc5a71b1a0", null, "Admin", "ADMIN" },
                    { "971f44ea-2e25-45bc-b3fd-a670a06070ff", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e45d2fb-807f-47b2-902b-e2dc5a71b1a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "971f44ea-2e25-45bc-b3fd-a670a06070ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b5d4833-f5e9-4f20-b182-f4fc7cb226b9", null, "Admin", "ADMIN" },
                    { "8f3e775e-72f7-43e0-84db-509111286d4c", null, "User", "USER" }
                });
        }
    }
}
