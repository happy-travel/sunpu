using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddTravelLineTravelClickSabreHeaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(table: "Suppliers", 
                keyColumn: "Code", 
                keyValue: "travelLine", 
                column: "CustomHeaders",  
                value: new Dictionary<string, string> {{ "Supplier-Context", "travelLine" }});
            
            migrationBuilder.UpdateData(table: "Suppliers", 
                keyColumn: "Code", 
                keyValue: "travelClick", 
                column: "CustomHeaders",  
                value: new Dictionary<string, string> {{ "Supplier-Context", "travelClick" }});
            
            migrationBuilder.UpdateData(table: "Suppliers", 
                keyColumn: "Code", 
                keyValue: "sabre", 
                column: "CustomHeaders",  
                value: new Dictionary<string, string> {{ "Supplier-Context", "synexis" }});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(table: "Suppliers", 
                keyColumn: "Code", 
                keyValue: "travelLine", 
                column: "CustomHeaders",  
                value: null);
            
            migrationBuilder.UpdateData(table: "Suppliers", 
                keyColumn: "Code", 
                keyValue: "travelClick", 
                column: "CustomHeaders",  
                value: null);
            
            migrationBuilder.UpdateData(table: "Suppliers", 
                keyColumn: "Code", 
                keyValue: "sabre", 
                column: "CustomHeaders",  
                value: null);
        }
    }
}
