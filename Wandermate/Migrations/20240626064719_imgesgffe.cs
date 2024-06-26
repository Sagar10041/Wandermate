using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wandermate.Migrations
{
    /// <inheritdoc />
    public partial class imgesgffe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestinationBooking_Destination_DestinationId",
                table: "DestinationBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReviews_Hotels_HotelsHotelId",
                table: "HotelReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomReviews_Rooms_RoomsRoomId",
                table: "RoomReviews");

            migrationBuilder.DropIndex(
                name: "IX_HotelReviews_HotelsHotelId",
                table: "HotelReviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac7de87c-eca4-4f6e-9c10-747f4410223c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edeae980-bbfe-40dd-9244-477047c11ef1");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomsRoomId",
                table: "RoomReviews",
                newName: "RoomsId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "RoomReviews",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_RoomReviews_RoomsRoomId",
                table: "RoomReviews",
                newName: "IX_RoomReviews_RoomsId");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Hotels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HotelsHotelId",
                table: "HotelReviews",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "HotelReviews",
                newName: "HotelsId");

            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "DestinationBooking",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DestinationBooking_DestinationId",
                table: "DestinationBooking",
                newName: "IX_DestinationBooking_Id");

            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "Destination",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DestinationReviews",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "324a0ace-5b9d-4146-9fbf-bf2133d154f6", null, "Admin", "ADMIN" },
                    { "4a7b69c8-5621-4e74-9257-417fe679027a", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReviews_HotelsId",
                table: "HotelReviews",
                column: "HotelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationBooking_Destination_Id",
                table: "DestinationBooking",
                column: "Id",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReviews_Hotels_HotelsId",
                table: "HotelReviews",
                column: "HotelsId",
                principalTable: "Hotels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReviews_Rooms_RoomsId",
                table: "RoomReviews",
                column: "RoomsId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestinationBooking_Destination_Id",
                table: "DestinationBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReviews_Hotels_HotelsId",
                table: "HotelReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomReviews_Rooms_RoomsId",
                table: "RoomReviews");

            migrationBuilder.DropIndex(
                name: "IX_HotelReviews_HotelsId",
                table: "HotelReviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "324a0ace-5b9d-4146-9fbf-bf2133d154f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a7b69c8-5621-4e74-9257-417fe679027a");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DestinationReviews");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "RoomsId",
                table: "RoomReviews",
                newName: "RoomsRoomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoomReviews",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomReviews_RoomsId",
                table: "RoomReviews",
                newName: "IX_RoomReviews_RoomsRoomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hotels",
                newName: "HotelId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HotelReviews",
                newName: "HotelsHotelId");

            migrationBuilder.RenameColumn(
                name: "HotelsId",
                table: "HotelReviews",
                newName: "HotelId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DestinationBooking",
                newName: "DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_DestinationBooking_Id",
                table: "DestinationBooking",
                newName: "IX_DestinationBooking_DestinationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Destination",
                newName: "DestinationId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac7de87c-eca4-4f6e-9c10-747f4410223c", null, "Admin", "ADMIN" },
                    { "edeae980-bbfe-40dd-9244-477047c11ef1", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReviews_HotelsHotelId",
                table: "HotelReviews",
                column: "HotelsHotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationBooking_Destination_DestinationId",
                table: "DestinationBooking",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReviews_Hotels_HotelsHotelId",
                table: "HotelReviews",
                column: "HotelsHotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReviews_Rooms_RoomsRoomId",
                table: "RoomReviews",
                column: "RoomsRoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId");
        }
    }
}
