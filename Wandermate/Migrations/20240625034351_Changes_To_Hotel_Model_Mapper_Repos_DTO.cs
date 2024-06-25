using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class Changes_To_Hotel_Model_Mapper_Repos_DTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5213dec3-2d42-4b50-a9d1-179341caa52a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de16d0a7-05a7-4231-bfec-a12303f40661");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Hotels",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Hotels",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "FreeCancellation",
                table: "Hotels",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Hotels",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Hotels",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ReserveNow",
                table: "Hotels",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ed3932b-d7fb-401e-b999-14dd0af12d6e", null, "Admin", "ADMIN" },
                    { "71c27d52-f9ac-4d48-a9ed-7f4ed8d6a5b0", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ed3932b-d7fb-401e-b999-14dd0af12d6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c27d52-f9ac-4d48-a9ed-7f4ed8d6a5b0");

            migrationBuilder.DropColumn(
                name: "FreeCancellation",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ReserveNow",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Hotels",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Hotels",
                newName: "City");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hotels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5213dec3-2d42-4b50-a9d1-179341caa52a", null, "Admin", "ADMIN" },
                    { "de16d0a7-05a7-4231-bfec-a12303f40661", null, "User", "USER" }
                });
        }
    }
}
