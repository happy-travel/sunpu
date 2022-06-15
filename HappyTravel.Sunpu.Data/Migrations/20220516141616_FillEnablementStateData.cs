using Microsoft.EntityFrameworkCore.Migrations;
using HappyTravel.Sunpu.Data.Models;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class FillEnablementStateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Suppliers", "IsEnabled", true, "EnablementState", 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
} 