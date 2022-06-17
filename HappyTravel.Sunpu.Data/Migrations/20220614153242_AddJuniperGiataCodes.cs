using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddJuniperGiataCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "Code", "bookMe", "GiataCode", "juniper");
            migrationBuilder.UpdateData("Suppliers", "Code", "roibos", "GiataCode", "juniper");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
