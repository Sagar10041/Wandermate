using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class imgesggg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cd86342-b3bc-4081-8ce6-43a788100f9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddeb7396-272f-4103-9add-41b75308fad4");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Destination");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Destination",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "FreeCancellation",
                table: "Destination",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<List<string>>(
                name: "Image",
                table: "Destination",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Destination",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Destination",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ReserveNow",
                table: "Destination",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac7de87c-eca4-4f6e-9c10-747f4410223c", null, "Admin", "ADMIN" },
                    { "edeae980-bbfe-40dd-9244-477047c11ef1", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac7de87c-eca4-4f6e-9c10-747f4410223c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edeae980-bbfe-40dd-9244-477047c11ef1");

            migrationBuilder.DropColumn(
                name: "FreeCancellation",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "ReserveNow",
                table: "Destination");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Destination",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Destination",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Destination",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cd86342-b3bc-4081-8ce6-43a788100f9f", null, "User", "USER" },
                    { "ddeb7396-272f-4103-9add-41b75308fad4", null, "Admin", "ADMIN" }
                });
        }
    }
}
