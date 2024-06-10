using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class identityAdduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c451edb-7501-4ac2-b64f-80ef6eecf911", null, "Admin", "ADMIN" },
                    { "60d9ddca-faa1-48ee-ad36-5e28243519d2", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c451edb-7501-4ac2-b64f-80ef6eecf911");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60d9ddca-faa1-48ee-ad36-5e28243519d2");
        }
    }
}
