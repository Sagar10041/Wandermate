using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class changedestination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "722bac67-5394-4db2-ad32-857c10a8e45a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2f97198-acd2-4eff-bd83-58ee51b34feb");

            migrationBuilder.RenameColumn(
                name: "DestinationReviewId",
                table: "DestinationReviews",
                newName: "ReviewId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75c0a94f-62f7-494e-a643-ed5b57a7fa78", null, "Admin", "ADMIN" },
                    { "a8ac1362-9c3d-48be-bcfa-85ac52d45b80", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75c0a94f-62f7-494e-a643-ed5b57a7fa78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8ac1362-9c3d-48be-bcfa-85ac52d45b80");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "DestinationReviews",
                newName: "DestinationReviewId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "722bac67-5394-4db2-ad32-857c10a8e45a", null, "Admin", "ADMIN" },
                    { "c2f97198-acd2-4eff-bd83-58ee51b34feb", null, "User", "USER" }
                });
        }
    }
}
