

#nullable disable

using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;
namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class FillModeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "IsEnabled", true, "Mode", (int) Mode.FullyEnabled);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "Mode", (int) Mode.FullyEnabled, "Mode", (int) Mode.Disabled);
        }
    }
}
