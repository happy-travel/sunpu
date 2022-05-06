﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddIsTestingOnlyFieldToSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTestingOnly",
                table: "Suppliers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTestingOnly",
                table: "Suppliers");
        }
    }
}
