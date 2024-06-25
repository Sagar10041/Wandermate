using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class Image_Datatype_To_List1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "054ab41b-9a3f-4f2f-9c66-6d81f3277300");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b57518f9-c8f8-47b1-b46e-bb754d3efd13");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b5d4833-f5e9-4f20-b182-f4fc7cb226b9", null, "Admin", "ADMIN" },
                    { "8f3e775e-72f7-43e0-84db-509111286d4c", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "054ab41b-9a3f-4f2f-9c66-6d81f3277300", null, "User", "USER" },
                    { "b57518f9-c8f8-47b1-b46e-bb754d3efd13", null, "Admin", "ADMIN" }
                });
        }
    }
}
