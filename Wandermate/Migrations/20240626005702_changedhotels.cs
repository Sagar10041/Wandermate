using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class changedhotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12eac313-9830-41d6-a196-6a91145388a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90be6b0c-e511-4613-87a3-2da31946d88c");

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
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Hotels",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ReserveNow",
                table: "Hotels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "675b07f9-4cce-4d79-9533-c338aa06704f", null, "Admin", "ADMIN" },
                    { "e22cf152-dd17-43bf-9500-3467dfa9fe75", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "675b07f9-4cce-4d79-9533-c338aa06704f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e22cf152-dd17-43bf-9500-3467dfa9fe75");

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
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12eac313-9830-41d6-a196-6a91145388a5", null, "User", "USER" },
                    { "90be6b0c-e511-4613-87a3-2da31946d88c", null, "Admin", "ADMIN" }
                });
        }
    }
}
