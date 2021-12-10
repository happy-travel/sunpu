using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddTableSuppllierActivationHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierActivationHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SupplierId = table.Column<int>(type: "integer", nullable: false),
                    IsEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierActivationHistory", x => x.Id);
                });

            var table = "Suppliers";
            migrationBuilder.InsertData(table, new string[] { "Id", "Name", "IsEnabled", "ConnectorUrl", "Created" }, new object[,]
            {
                { 18, "BookMe Maldives", false, "https://tg-dev.happytravel.com/api/1.0/bokm/", DateTime.UtcNow },
                { 19, "Roibos", false, "https://tg-dev.happytravel.com/api/1.0/roi/", DateTime.UtcNow }
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierActivationHistory");
        }
    }
}
