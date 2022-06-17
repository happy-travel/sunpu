using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class RenameEnablementState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnablementState",
                table: "Suppliers",
                newName: "EnableState");

            migrationBuilder.RenameColumn(
                name: "EnablementState",
                table: "SupplierActivationHistory",
                newName: "EnableState");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnableState",
                table: "Suppliers",
                newName: "EnablementState");

            migrationBuilder.RenameColumn(
                name: "EnableState",
                table: "SupplierActivationHistory",
                newName: "EnablementState");
        }
    }
}
