using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddIsMultiRoomSupported : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMultiRoomSupported",
                table: "Suppliers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            var table = "Suppliers";
            var keyColumn = "Id";
            var column = "IsMultiRoomSupported";
            migrationBuilder.UpdateData(table, keyColumn, 1, column, true); // Netstorming
            migrationBuilder.UpdateData(table, keyColumn, 2, column, true); // iWTX
            migrationBuilder.UpdateData(table, keyColumn, 4, column, true); // RateHawk
            migrationBuilder.UpdateData(table, keyColumn, 7, column, true); // TravelgateX (TEST)
            migrationBuilder.UpdateData(table, keyColumn, 8, column, true); // Jumeirah Hotels
            migrationBuilder.UpdateData(table, keyColumn, 9, column, true); // Darina Holidays
            migrationBuilder.UpdateData(table, keyColumn, 10, column, true); // Yalago
            migrationBuilder.UpdateData(table, keyColumn, 11, column, true); // Paximum
            migrationBuilder.UpdateData(table, keyColumn, 13, column, true); // Bronevik
            migrationBuilder.UpdateData(table, keyColumn, 16, column, true); // HotelBeds
            migrationBuilder.UpdateData(table, keyColumn, 18, column, true); // BookMe Maldives
            migrationBuilder.UpdateData(table, keyColumn, 19, column, true); // Roibos
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMultiRoomSupported",
                table: "Suppliers");
        }
    }
}
