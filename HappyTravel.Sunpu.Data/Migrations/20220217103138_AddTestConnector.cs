using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddTestConnector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Suppliers", new string[] { "Id", "Code", "Name", "IsEnabled", "ConnectorUrl", "ConnectorGrpcEndpoint", "Created", "IsMultiRoomFlowSupported" }, new object[,]
            {
                { 33, "htTest", "HappyTravel Test Connector", false, "https://tc-dev.happytravel.com/api/1.0/", "http://tc-dev", DateTimeOffset.UtcNow, true }
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Suppliers", "Id", 33);
        }
    }
}
