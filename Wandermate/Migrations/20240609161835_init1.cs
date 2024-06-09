using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewerName",
                table: "HotelReviews");

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "HotelReviews",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "HotelReviews");

            migrationBuilder.AddColumn<string>(
                name: "ReviewerName",
                table: "HotelReviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
