

#nullable disable

using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;
namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class FillModeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "IsEnabled", true, "OperationMode", (int) OperationMode.Enabled);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "OperationMode", (int) OperationMode.Enabled, "OperationMode", (int) OperationMode.Disabled);
        }
    }
}
