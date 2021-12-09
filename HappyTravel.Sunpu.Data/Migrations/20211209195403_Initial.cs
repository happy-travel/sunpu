using System;
using System.Collections.Generic;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    ConnectorUrl = table.Column<string>(type: "text", nullable: false),
                    WebSite = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PrimaryContact = table.Column<Contact>(type: "jsonb", nullable: true),
                    SupportContacts = table.Column<List<Contact>>(type: "jsonb", nullable: true),
                    ReservationsContacts = table.Column<List<Contact>>(type: "jsonb", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            var table = "Suppliers";
            migrationBuilder.InsertData(table, new string[] { "Id", "Name", "IsEnabled", "ConnectorUrl", "Created" }, new object[,]
            {
                { 1, "Netstorming", true, "https://ns-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 2, "iWTX", true, "https://iwtx-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 3, "Direct Contracts", false, "https://dc-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 4, "RateHawk", true, "https://etg-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 5, "Rakuten Travel Xchange", true, "https://rakuten-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 6, "Columbus (Direct Contracts)", true, "https://wq-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 7, "TravelgateX (TEST)", true, "https://tg-dev.happytravel.com/api/1.0/hoteltest/", DateTime.UtcNow },
                { 8, "Jumeirah Hotels", true, "https://jmr-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 9, "Darina Holidays", false, "https://tg-dev.happytravel.com/api/1.0/drn/", DateTime.UtcNow },
                { 10, "Yalago", false, "https://tg-dev.happytravel.com/api/1.0/yag/", DateTime.UtcNow },
                { 11, "Paximum", false, "https://tg-dev.happytravel.com/api/1.0/pax/", DateTime.UtcNow },
                { 12, "TravelLine OÜ", false, "", DateTime.UtcNow },
                { 13, "Bronevik", true, "https://bc-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 14, "Amadeus Hospitality", false, "", DateTime.UtcNow },
                { 15, "Sodis", false, "", DateTime.UtcNow },
                { 16, "HotelBeds", true, "https://hc-dev.happytravel.com/api/1.0/", DateTime.UtcNow },
                { 17, "Hotelbook Pro", false, "https://hpc-dev.happytravel.com/api/1.0/", DateTime.UtcNow }
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
