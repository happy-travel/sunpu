using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddCanUseGrpcColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanUseGrpc",
                table: "Suppliers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanUseGrpc",
                table: "Suppliers");
        }
    }
}
