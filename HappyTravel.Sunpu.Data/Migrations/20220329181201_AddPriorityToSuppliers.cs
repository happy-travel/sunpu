using System.Collections.Generic;
using HappyTravel.MapperContracts.Public.Accommodations.Enums;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddPriorityToSuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Dictionary<AccommodationDataTypes, int>>(
                name: "Priority",
                table: "Suppliers",
                type: "jsonb",
                nullable: true);

            var table = "Suppliers";
            var keyColumn = "Code";
            var column = "Priority";
            migrationBuilder.UpdateData(table, keyColumn, "netstorming", column, new Dictionary<AccommodationDataTypes, int> 
            {
                { AccommodationDataTypes.Name, 6 },
                { AccommodationDataTypes.Photos, 7 },
                { AccommodationDataTypes.Rating, 6 },
                { AccommodationDataTypes.Category, 6 },
                { AccommodationDataTypes.Schedule, 6 },
                { AccommodationDataTypes.ContactInfo, 6 },
                { AccommodationDataTypes.LocationInfo, 6 },
                { AccommodationDataTypes.PropertyType, 6 },
                { AccommodationDataTypes.RoomAmenities, 6 },
                { AccommodationDataTypes.AdditionalInfo, 6 },
                { AccommodationDataTypes.TypeDescription, 6 },
                { AccommodationDataTypes.TextualDescriptions, 6 },
                { AccommodationDataTypes.AccommodationAmenities, 6 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "illusions", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 7 },
                { AccommodationDataTypes.Photos, 8 },
                { AccommodationDataTypes.Rating, 7 },
                { AccommodationDataTypes.Category, 7 },
                { AccommodationDataTypes.Schedule, 7 },
                { AccommodationDataTypes.ContactInfo, 7 },
                { AccommodationDataTypes.LocationInfo, 7 },
                { AccommodationDataTypes.PropertyType, 7 },
                { AccommodationDataTypes.RoomAmenities, 7 },
                { AccommodationDataTypes.AdditionalInfo, 7 },
                { AccommodationDataTypes.TypeDescription, 7 },
                { AccommodationDataTypes.TextualDescriptions, 7 },
                { AccommodationDataTypes.AccommodationAmenities, 7 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "directContracts", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 5 },
                { AccommodationDataTypes.Photos, 6 },
                { AccommodationDataTypes.Rating, 5 },
                { AccommodationDataTypes.Category, 5 },
                { AccommodationDataTypes.Schedule, 5 },
                { AccommodationDataTypes.ContactInfo, 5 },
                { AccommodationDataTypes.LocationInfo, 5 },
                { AccommodationDataTypes.PropertyType, 5 },
                { AccommodationDataTypes.RoomAmenities, 5 },
                { AccommodationDataTypes.AdditionalInfo, 5 },
                { AccommodationDataTypes.TypeDescription, 5 },
                { AccommodationDataTypes.TextualDescriptions, 5 },
                { AccommodationDataTypes.AccommodationAmenities, 5 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "etg", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 4 },
                { AccommodationDataTypes.Photos, 5 },
                { AccommodationDataTypes.Rating, 4 },
                { AccommodationDataTypes.Category, 4 },
                { AccommodationDataTypes.Schedule, 4 },
                { AccommodationDataTypes.ContactInfo, 4 },
                { AccommodationDataTypes.LocationInfo, 4 },
                { AccommodationDataTypes.PropertyType, 4 },
                { AccommodationDataTypes.RoomAmenities, 4 },
                { AccommodationDataTypes.AdditionalInfo, 4 },
                { AccommodationDataTypes.TypeDescription, 4 },
                { AccommodationDataTypes.TextualDescriptions, 4 },
                { AccommodationDataTypes.AccommodationAmenities, 4 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "rakuten", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 8 },
                { AccommodationDataTypes.Photos, 9 },
                { AccommodationDataTypes.Rating, 8 },
                { AccommodationDataTypes.Category, 8 },
                { AccommodationDataTypes.Schedule, 8 },
                { AccommodationDataTypes.ContactInfo, 8 },
                { AccommodationDataTypes.LocationInfo, 8 },
                { AccommodationDataTypes.PropertyType, 8 },
                { AccommodationDataTypes.RoomAmenities, 8 },
                { AccommodationDataTypes.AdditionalInfo, 8 },
                { AccommodationDataTypes.TypeDescription, 8 },
                { AccommodationDataTypes.TextualDescriptions, 8 },
                { AccommodationDataTypes.AccommodationAmenities, 8 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "columbus", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 1 },
                { AccommodationDataTypes.Photos, 2 },
                { AccommodationDataTypes.Rating, 1 },
                { AccommodationDataTypes.Category, 1 },
                { AccommodationDataTypes.Schedule, 1 },
                { AccommodationDataTypes.ContactInfo, 1 },
                { AccommodationDataTypes.LocationInfo, 1 },
                { AccommodationDataTypes.PropertyType, 1 },
                { AccommodationDataTypes.RoomAmenities, 1 },
                { AccommodationDataTypes.AdditionalInfo, 1 },
                { AccommodationDataTypes.TypeDescription, 1 },
                { AccommodationDataTypes.TextualDescriptions, 1 },
                { AccommodationDataTypes.AccommodationAmenities, 1 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "travelgateXTest", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 9 },
                { AccommodationDataTypes.Photos, 10 },
                { AccommodationDataTypes.Rating, 9 },
                { AccommodationDataTypes.Category, 9 },
                { AccommodationDataTypes.Schedule, 9 },
                { AccommodationDataTypes.ContactInfo, 9 },
                { AccommodationDataTypes.LocationInfo, 9 },
                { AccommodationDataTypes.PropertyType, 9 },
                { AccommodationDataTypes.RoomAmenities, 9 },
                { AccommodationDataTypes.AdditionalInfo, 9 },
                { AccommodationDataTypes.TypeDescription, 9 },
                { AccommodationDataTypes.TextualDescriptions, 9 },
                { AccommodationDataTypes.AccommodationAmenities, 9 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "jumeirah", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 2 },
                { AccommodationDataTypes.Photos, 3 },
                { AccommodationDataTypes.Rating, 2 },
                { AccommodationDataTypes.Category, 2 },
                { AccommodationDataTypes.Schedule, 2 },
                { AccommodationDataTypes.ContactInfo, 2 },
                { AccommodationDataTypes.LocationInfo, 2 },
                { AccommodationDataTypes.PropertyType, 2 },
                { AccommodationDataTypes.RoomAmenities, 2 },
                { AccommodationDataTypes.AdditionalInfo, 2 },
                { AccommodationDataTypes.TypeDescription, 2 },
                { AccommodationDataTypes.TextualDescriptions, 2 },
                { AccommodationDataTypes.AccommodationAmenities, 2 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "darina", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 3 },
                { AccommodationDataTypes.Photos, 4 },
                { AccommodationDataTypes.Rating, 3 },
                { AccommodationDataTypes.Category, 3 },
                { AccommodationDataTypes.Schedule, 3 },
                { AccommodationDataTypes.ContactInfo, 3 },
                { AccommodationDataTypes.LocationInfo, 3 },
                { AccommodationDataTypes.PropertyType, 3 },
                { AccommodationDataTypes.RoomAmenities, 3 },
                { AccommodationDataTypes.AdditionalInfo, 3 },
                { AccommodationDataTypes.TypeDescription, 3 },
                { AccommodationDataTypes.TextualDescriptions, 3 },
                { AccommodationDataTypes.AccommodationAmenities, 3 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "yalago", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 10 },
                { AccommodationDataTypes.Photos, 11 },
                { AccommodationDataTypes.Rating, 10 },
                { AccommodationDataTypes.Category, 10 },
                { AccommodationDataTypes.Schedule, 10 },
                { AccommodationDataTypes.ContactInfo, 10 },
                { AccommodationDataTypes.LocationInfo, 10 },
                { AccommodationDataTypes.PropertyType, 10 },
                { AccommodationDataTypes.RoomAmenities, 10 },
                { AccommodationDataTypes.AdditionalInfo, 10 },
                { AccommodationDataTypes.TypeDescription, 10 },
                { AccommodationDataTypes.TextualDescriptions, 10 },
                { AccommodationDataTypes.AccommodationAmenities, 10 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "paximum", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 11 },
                { AccommodationDataTypes.Photos, 12 },
                { AccommodationDataTypes.Rating, 11 },
                { AccommodationDataTypes.Category, 11 },
                { AccommodationDataTypes.Schedule, 11 },
                { AccommodationDataTypes.ContactInfo, 11 },
                { AccommodationDataTypes.LocationInfo, 11 },
                { AccommodationDataTypes.PropertyType, 11 },
                { AccommodationDataTypes.RoomAmenities, 11 },
                { AccommodationDataTypes.AdditionalInfo, 11 },
                { AccommodationDataTypes.TypeDescription, 11 },
                { AccommodationDataTypes.TextualDescriptions, 11 },
                { AccommodationDataTypes.AccommodationAmenities, 11 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bronevik", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 14 },
                { AccommodationDataTypes.Photos, 14 },
                { AccommodationDataTypes.Rating, 14 },
                { AccommodationDataTypes.Category, 14 },
                { AccommodationDataTypes.Schedule, 14 },
                { AccommodationDataTypes.ContactInfo, 14 },
                { AccommodationDataTypes.LocationInfo, 14 },
                { AccommodationDataTypes.PropertyType, 14 },
                { AccommodationDataTypes.RoomAmenities, 14 },
                { AccommodationDataTypes.AdditionalInfo, 14 },
                { AccommodationDataTypes.TypeDescription, 14 },
                { AccommodationDataTypes.TextualDescriptions, 14 },
                { AccommodationDataTypes.AccommodationAmenities, 14 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hotelBeds", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 13 },
                { AccommodationDataTypes.Photos, 1 },
                { AccommodationDataTypes.Rating, 13 },
                { AccommodationDataTypes.Category, 13 },
                { AccommodationDataTypes.Schedule, 13 },
                { AccommodationDataTypes.ContactInfo, 13 },
                { AccommodationDataTypes.LocationInfo, 13 },
                { AccommodationDataTypes.PropertyType, 13 },
                { AccommodationDataTypes.RoomAmenities, 13 },
                { AccommodationDataTypes.AdditionalInfo, 13 },
                { AccommodationDataTypes.TypeDescription, 13 },
                { AccommodationDataTypes.TextualDescriptions, 13 },
                { AccommodationDataTypes.AccommodationAmenities, 13 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hotelbookPro", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 12 },
                { AccommodationDataTypes.Photos, 13 },
                { AccommodationDataTypes.Rating, 12 },
                { AccommodationDataTypes.Category, 12 },
                { AccommodationDataTypes.Schedule, 12 },
                { AccommodationDataTypes.ContactInfo, 12 },
                { AccommodationDataTypes.LocationInfo, 12 },
                { AccommodationDataTypes.PropertyType, 12 },
                { AccommodationDataTypes.RoomAmenities, 12 },
                { AccommodationDataTypes.AdditionalInfo, 12 },
                { AccommodationDataTypes.TypeDescription, 12 },
                { AccommodationDataTypes.TextualDescriptions, 12 },
                { AccommodationDataTypes.AccommodationAmenities, 12 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bookMe", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 15 },
                { AccommodationDataTypes.Photos, 15 },
                { AccommodationDataTypes.Rating, 15 },
                { AccommodationDataTypes.Category, 15 },
                { AccommodationDataTypes.Schedule, 15 },
                { AccommodationDataTypes.ContactInfo, 15 },
                { AccommodationDataTypes.LocationInfo, 15 },
                { AccommodationDataTypes.PropertyType, 15 },
                { AccommodationDataTypes.RoomAmenities, 15 },
                { AccommodationDataTypes.AdditionalInfo, 15 },
                { AccommodationDataTypes.TypeDescription, 15 },
                { AccommodationDataTypes.TextualDescriptions, 15 },
                { AccommodationDataTypes.AccommodationAmenities, 15 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "roibos", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 16 },
                { AccommodationDataTypes.Photos, 16 },
                { AccommodationDataTypes.Rating, 16 },
                { AccommodationDataTypes.Category, 16 },
                { AccommodationDataTypes.Schedule, 16 },
                { AccommodationDataTypes.ContactInfo, 16 },
                { AccommodationDataTypes.LocationInfo, 16 },
                { AccommodationDataTypes.PropertyType, 16 },
                { AccommodationDataTypes.RoomAmenities, 16 },
                { AccommodationDataTypes.AdditionalInfo, 16 },
                { AccommodationDataTypes.TypeDescription, 16 },
                { AccommodationDataTypes.TextualDescriptions, 16 },
                { AccommodationDataTypes.AccommodationAmenities, 16 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "avraTours", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 17 },
                { AccommodationDataTypes.Photos, 17 },
                { AccommodationDataTypes.Rating, 17 },
                { AccommodationDataTypes.Category, 17 },
                { AccommodationDataTypes.Schedule, 17 },
                { AccommodationDataTypes.ContactInfo, 17 },
                { AccommodationDataTypes.LocationInfo, 17 },
                { AccommodationDataTypes.PropertyType, 17 },
                { AccommodationDataTypes.RoomAmenities, 17 },
                { AccommodationDataTypes.AdditionalInfo, 17 },
                { AccommodationDataTypes.TypeDescription, 17 },
                { AccommodationDataTypes.TextualDescriptions, 17 },
                { AccommodationDataTypes.AccommodationAmenities, 17 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "accor", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 18 },
                { AccommodationDataTypes.Photos, 18 },
                { AccommodationDataTypes.Rating, 18 },
                { AccommodationDataTypes.Category, 18 },
                { AccommodationDataTypes.Schedule, 18 },
                { AccommodationDataTypes.ContactInfo, 18 },
                { AccommodationDataTypes.LocationInfo, 18 },
                { AccommodationDataTypes.PropertyType, 18 },
                { AccommodationDataTypes.RoomAmenities, 18 },
                { AccommodationDataTypes.AdditionalInfo, 18 },
                { AccommodationDataTypes.TypeDescription, 18 },
                { AccommodationDataTypes.TextualDescriptions, 18 },
                { AccommodationDataTypes.AccommodationAmenities, 18 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hyperGuest", column, new Dictionary<AccommodationDataTypes, int>
            {
                { AccommodationDataTypes.Name, 19 },
                { AccommodationDataTypes.Photos, 19 },
                { AccommodationDataTypes.Rating, 19 },
                { AccommodationDataTypes.Category, 19 },
                { AccommodationDataTypes.Schedule, 19 },
                { AccommodationDataTypes.ContactInfo, 19 },
                { AccommodationDataTypes.LocationInfo, 19 },
                { AccommodationDataTypes.PropertyType, 19 },
                { AccommodationDataTypes.RoomAmenities, 19 },
                { AccommodationDataTypes.AdditionalInfo, 19 },
                { AccommodationDataTypes.TypeDescription, 19 },
                { AccommodationDataTypes.TextualDescriptions, 19 },
                { AccommodationDataTypes.AccommodationAmenities, 19 }
            });

            var suppliersWithoutPriority = new List<string>
            {
                "travelLine",
                "travelClick",
                "sodis",
                "sabre",
                "bakuun",
                "nirvana",
                "nuitee",
                "solole",
                "grnConnect",
                "methabook",
                "withinearth",
                "mtsCityBreaks",
                "ddHolidays",
                "htTest",
                "illusionsDirect"
            };
            var numberOfSuppliers = 34;
            foreach (var supplier in suppliersWithoutPriority)
            {
                migrationBuilder.UpdateData(table, keyColumn, supplier, column, new Dictionary<AccommodationDataTypes, int>
                {
                    { AccommodationDataTypes.Name, numberOfSuppliers },
                    { AccommodationDataTypes.Photos, numberOfSuppliers },
                    { AccommodationDataTypes.Rating, numberOfSuppliers },
                    { AccommodationDataTypes.Category, numberOfSuppliers },
                    { AccommodationDataTypes.Schedule, numberOfSuppliers },
                    { AccommodationDataTypes.ContactInfo, numberOfSuppliers },
                    { AccommodationDataTypes.LocationInfo, numberOfSuppliers },
                    { AccommodationDataTypes.PropertyType, numberOfSuppliers },
                    { AccommodationDataTypes.RoomAmenities, numberOfSuppliers },
                    { AccommodationDataTypes.AdditionalInfo, numberOfSuppliers },
                    { AccommodationDataTypes.TypeDescription, numberOfSuppliers },
                    { AccommodationDataTypes.TextualDescriptions, numberOfSuppliers },
                    { AccommodationDataTypes.AccommodationAmenities, numberOfSuppliers }
                });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Suppliers");
        }
    }
}
