using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class tesai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d356ae5-6b68-4df5-889e-b5b3cc566c05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56031e4f-15f2-4ea9-80e8-22e611e37b81");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "HotelReviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b46e097-cb30-499d-b78e-8afb904ff7af", null, "User", "USER" },
                    { "f98655d7-6e96-44f0-a76b-b6e96e178392", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReviews_AppUserId",
                table: "HotelReviews",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReviews_AspNetUsers_AppUserId",
                table: "HotelReviews",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelReviews_AspNetUsers_AppUserId",
                table: "HotelReviews");

            migrationBuilder.DropIndex(
                name: "IX_HotelReviews_AppUserId",
                table: "HotelReviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b46e097-cb30-499d-b78e-8afb904ff7af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98655d7-6e96-44f0-a76b-b6e96e178392");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "HotelReviews");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d356ae5-6b68-4df5-889e-b5b3cc566c05", null, "Admin", "ADMIN" },
                    { "56031e4f-15f2-4ea9-80e8-22e611e37b81", null, "User", "USER" }
                });
        }
    }
}
