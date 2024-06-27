using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "324a0ace-5b9d-4146-9fbf-bf2133d154f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a7b69c8-5621-4e74-9257-417fe679027a");

            migrationBuilder.CreateTable(
                name: "HotelBookings",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelBookings", x => new { x.AppUserId, x.Id });
                    table.ForeignKey(
                        name: "FK_HotelBookings_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelBookings_Hotels_Id",
                        column: x => x.Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d356ae5-6b68-4df5-889e-b5b3cc566c05", null, "Admin", "ADMIN" },
                    { "56031e4f-15f2-4ea9-80e8-22e611e37b81", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelBookings_Id",
                table: "HotelBookings",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelBookings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d356ae5-6b68-4df5-889e-b5b3cc566c05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56031e4f-15f2-4ea9-80e8-22e611e37b81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "324a0ace-5b9d-4146-9fbf-bf2133d154f6", null, "Admin", "ADMIN" },
                    { "4a7b69c8-5621-4e74-9257-417fe679027a", null, "User", "USER" }
                });
        }
    }
}
