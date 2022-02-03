using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddNewSuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Suppliers", new string[] { "Id", "Name", "IsEnabled", "ConnectorUrl", "Created", "IsMultiRoomFlowSupported" }, new object[,]
            {
                { 20, "Sabre", false, "", DateTimeOffset.UtcNow, true },
                { 21, "Bakuun", false, "", DateTimeOffset.UtcNow, true },
                { 22, "Accor", false, "", DateTimeOffset.UtcNow, true },
                { 23, "Nirvana", false, "", DateTimeOffset.UtcNow, true },
                { 24, "Nuitee", false, "", DateTimeOffset.UtcNow, true },
                { 25, "HyperGuest", false, "", DateTimeOffset.UtcNow, true },
                { 26, "Solole", false, "", DateTimeOffset.UtcNow, true },
                { 27, "GRN connect", false, "", DateTimeOffset.UtcNow, true },
                { 28, "Methabook", false, "", DateTimeOffset.UtcNow, true },
                { 29, "Withinearth", false, "", DateTimeOffset.UtcNow, true },
                { 30, "MTS City Breaks", false, "", DateTimeOffset.UtcNow, true },
                { 31, "Avra Tours", true, "https://tg-dev.happytravel.com/api/1.0/avr/", DateTimeOffset.UtcNow, true },
                { 32, "DD Holidays", false, "", DateTimeOffset.UtcNow, true }
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
