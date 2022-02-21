using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddIwtxDirectConnector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Suppliers", new string[] { "Id", "Code", "Name", "IsEnabled", "ConnectorUrl", "ConnectorGrpcEndpoint", "Created", "IsMultiRoomFlowSupported", "CustomHeaders" }, new object[,]
            {
                { 34, "illusionsDirect", "iWTX (Direct)", false, "https://iwtx-dev.happytravel.com/api/1.0/", null, DateTimeOffset.UtcNow, true, new Dictionary<string, string> {{ "IWTX-Client-Context", "direct" }} }
            });
            
            migrationBuilder.UpdateData("Suppliers", "Id", 2, "CustomHeaders",  new Dictionary<string, string> {{ "IWTX-Client-Context", "default" }});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Suppliers", "Id", 34);
            migrationBuilder.UpdateData("Suppliers", "Id", 2, "CustomHeaders",  null);
        }
    }
}
