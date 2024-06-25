using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class ChangesMadeNotWorking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "04e1286c-590b-475a-8269-2ce6e0e26ec2", null, "Admin", "ADMIN" },
                    { "422e52c4-f38b-4d96-a2e9-f2ab9d4d04b7", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04e1286c-590b-475a-8269-2ce6e0e26ec2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422e52c4-f38b-4d96-a2e9-f2ab9d4d04b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "357a2612-02de-4e01-8cd1-d984a494a353", null, "User", "USER" },
                    { "667ac3a4-0cbc-440b-b857-a3f944e2b52a", null, "Admin", "ADMIN" }
                });
        }
    }
}
