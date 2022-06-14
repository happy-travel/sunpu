using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class FillGiataCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "Code", "etg", "GiataCode", "ostrovok2");
            migrationBuilder.UpdateData("Suppliers", "Code", "darina", "GiataCode", "darinaholidays");
            migrationBuilder.UpdateData("Suppliers", "Code", "illusions", "GiataCode", "iol_iwtx");
            migrationBuilder.UpdateData("Suppliers", "Code", "methabook", "GiataCode", "methabook2");
            migrationBuilder.UpdateData("Suppliers", "Code", "nuitee", "GiataCode", "nuitee");
            migrationBuilder.UpdateData("Suppliers", "Code", "paximum", "GiataCode", "paximum");
            migrationBuilder.UpdateData("Suppliers", "Code", "yalago", "GiataCode", "yalago");
            migrationBuilder.UpdateData("Suppliers", "Code", "solole", "GiataCode", "solole");
            migrationBuilder.UpdateData("Suppliers", "Code", "rakuten", "GiataCode", "zumata");
            migrationBuilder.UpdateData("Suppliers", "Code", "accor", "GiataCode", "gekko_infinite");
            migrationBuilder.UpdateData("Suppliers", "Code", "netstorming", "GiataCode", "netstorming");
            migrationBuilder.UpdateData("Suppliers", "Code", "bronevik", "GiataCode", "bronevik");
            migrationBuilder.UpdateData("Suppliers", "Code", "hotelbeds", "GiataCode", "hotelbeds");
            migrationBuilder.UpdateData("Suppliers", "Code", "hyperGuest", "GiataCode", "hyperguest");
            migrationBuilder.UpdateData("Suppliers", "Code", "withinearth", "GiataCode", "withinearth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
