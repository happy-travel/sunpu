using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddSupplierCustomHeaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Dictionary<string, string>>(
                name: "CustomHeaders",
                table: "Suppliers",
                type: "jsonb",
                nullable: true);

            migrationBuilder.UpdateData("Suppliers", "Id", 7, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "HOTELTEST" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 9, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "DRN" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 10, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "YAG" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 11, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "PAX" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 18, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "BOKM" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 19, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "ROI" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 22, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "INF" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 24, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "NUTE2" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 24, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "NUTE2" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 24, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "NUTE2" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 26, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "ISOL" }});
            migrationBuilder.UpdateData("Suppliers", "Id", 31, "CustomHeaders",  new Dictionary<string, string> {{ "TGX-Supplier-Context", "AVR" }});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomHeaders",
                table: "Suppliers");
        }
    }
}
