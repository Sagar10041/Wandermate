using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class switching_postgreSQL_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ed3932b-d7fb-401e-b999-14dd0af12d6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c27d52-f9ac-4d48-a9ed-7f4ed8d6a5b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "357a2612-02de-4e01-8cd1-d984a494a353", null, "User", "USER" },
                    { "667ac3a4-0cbc-440b-b857-a3f944e2b52a", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "357a2612-02de-4e01-8cd1-d984a494a353");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "667ac3a4-0cbc-440b-b857-a3f944e2b52a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ed3932b-d7fb-401e-b999-14dd0af12d6e", null, "Admin", "ADMIN" },
                    { "71c27d52-f9ac-4d48-a9ed-7f4ed8d6a5b0", null, "User", "USER" }
                });
        }
    }
}
