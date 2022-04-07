using System.Collections.Generic;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    public partial class AddPriorityToSuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Dictionary<PriorityTypes, int>>(
                name: "Priority",
                table: "Suppliers",
                type: "jsonb",
                nullable: true);

            var table = "Suppliers";
            var keyColumn = "Code";
            var column = "Priority";
            migrationBuilder.UpdateData(table, keyColumn, "netstorming", column, new Dictionary<PriorityTypes, int> 
            {
                { PriorityTypes.Name, 6 },
                { PriorityTypes.Photos, 7 },
                { PriorityTypes.Rating, 6 },
                { PriorityTypes.Category, 6 },
                { PriorityTypes.Schedule, 6 },
                { PriorityTypes.ContactInfo, 6 },
                { PriorityTypes.LocationInfo, 6 },
                { PriorityTypes.PropertyType, 6 },
                { PriorityTypes.RoomAmenities, 6 },
                { PriorityTypes.AdditionalInfo, 6 },
                { PriorityTypes.TypeDescription, 6 },
                { PriorityTypes.TextualDescriptions, 6 },
                { PriorityTypes.AccommodationAmenities, 6 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "illusions", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 7 },
                { PriorityTypes.Photos, 8 },
                { PriorityTypes.Rating, 7 },
                { PriorityTypes.Category, 7 },
                { PriorityTypes.Schedule, 7 },
                { PriorityTypes.ContactInfo, 7 },
                { PriorityTypes.LocationInfo, 7 },
                { PriorityTypes.PropertyType, 7 },
                { PriorityTypes.RoomAmenities, 7 },
                { PriorityTypes.AdditionalInfo, 7 },
                { PriorityTypes.TypeDescription, 7 },
                { PriorityTypes.TextualDescriptions, 7 },
                { PriorityTypes.AccommodationAmenities, 7 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "directContracts", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 5 },
                { PriorityTypes.Photos, 6 },
                { PriorityTypes.Rating, 5 },
                { PriorityTypes.Category, 5 },
                { PriorityTypes.Schedule, 5 },
                { PriorityTypes.ContactInfo, 5 },
                { PriorityTypes.LocationInfo, 5 },
                { PriorityTypes.PropertyType, 5 },
                { PriorityTypes.RoomAmenities, 5 },
                { PriorityTypes.AdditionalInfo, 5 },
                { PriorityTypes.TypeDescription, 5 },
                { PriorityTypes.TextualDescriptions, 5 },
                { PriorityTypes.AccommodationAmenities, 5 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "etg", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 4 },
                { PriorityTypes.Photos, 5 },
                { PriorityTypes.Rating, 4 },
                { PriorityTypes.Category, 4 },
                { PriorityTypes.Schedule, 4 },
                { PriorityTypes.ContactInfo, 4 },
                { PriorityTypes.LocationInfo, 4 },
                { PriorityTypes.PropertyType, 4 },
                { PriorityTypes.RoomAmenities, 4 },
                { PriorityTypes.AdditionalInfo, 4 },
                { PriorityTypes.TypeDescription, 4 },
                { PriorityTypes.TextualDescriptions, 4 },
                { PriorityTypes.AccommodationAmenities, 4 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "rakuten", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 8 },
                { PriorityTypes.Photos, 9 },
                { PriorityTypes.Rating, 8 },
                { PriorityTypes.Category, 8 },
                { PriorityTypes.Schedule, 8 },
                { PriorityTypes.ContactInfo, 8 },
                { PriorityTypes.LocationInfo, 8 },
                { PriorityTypes.PropertyType, 8 },
                { PriorityTypes.RoomAmenities, 8 },
                { PriorityTypes.AdditionalInfo, 8 },
                { PriorityTypes.TypeDescription, 8 },
                { PriorityTypes.TextualDescriptions, 8 },
                { PriorityTypes.AccommodationAmenities, 8 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "columbus", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 1 },
                { PriorityTypes.Photos, 2 },
                { PriorityTypes.Rating, 1 },
                { PriorityTypes.Category, 1 },
                { PriorityTypes.Schedule, 1 },
                { PriorityTypes.ContactInfo, 1 },
                { PriorityTypes.LocationInfo, 1 },
                { PriorityTypes.PropertyType, 1 },
                { PriorityTypes.RoomAmenities, 1 },
                { PriorityTypes.AdditionalInfo, 1 },
                { PriorityTypes.TypeDescription, 1 },
                { PriorityTypes.TextualDescriptions, 1 },
                { PriorityTypes.AccommodationAmenities, 1 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "travelgateXTest", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 9 },
                { PriorityTypes.Photos, 10 },
                { PriorityTypes.Rating, 9 },
                { PriorityTypes.Category, 9 },
                { PriorityTypes.Schedule, 9 },
                { PriorityTypes.ContactInfo, 9 },
                { PriorityTypes.LocationInfo, 9 },
                { PriorityTypes.PropertyType, 9 },
                { PriorityTypes.RoomAmenities, 9 },
                { PriorityTypes.AdditionalInfo, 9 },
                { PriorityTypes.TypeDescription, 9 },
                { PriorityTypes.TextualDescriptions, 9 },
                { PriorityTypes.AccommodationAmenities, 9 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "jumeirah", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 2 },
                { PriorityTypes.Photos, 3 },
                { PriorityTypes.Rating, 2 },
                { PriorityTypes.Category, 2 },
                { PriorityTypes.Schedule, 2 },
                { PriorityTypes.ContactInfo, 2 },
                { PriorityTypes.LocationInfo, 2 },
                { PriorityTypes.PropertyType, 2 },
                { PriorityTypes.RoomAmenities, 2 },
                { PriorityTypes.AdditionalInfo, 2 },
                { PriorityTypes.TypeDescription, 2 },
                { PriorityTypes.TextualDescriptions, 2 },
                { PriorityTypes.AccommodationAmenities, 2 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "darina", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 3 },
                { PriorityTypes.Photos, 4 },
                { PriorityTypes.Rating, 3 },
                { PriorityTypes.Category, 3 },
                { PriorityTypes.Schedule, 3 },
                { PriorityTypes.ContactInfo, 3 },
                { PriorityTypes.LocationInfo, 3 },
                { PriorityTypes.PropertyType, 3 },
                { PriorityTypes.RoomAmenities, 3 },
                { PriorityTypes.AdditionalInfo, 3 },
                { PriorityTypes.TypeDescription, 3 },
                { PriorityTypes.TextualDescriptions, 3 },
                { PriorityTypes.AccommodationAmenities, 3 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "yalago", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 10 },
                { PriorityTypes.Photos, 11 },
                { PriorityTypes.Rating, 10 },
                { PriorityTypes.Category, 10 },
                { PriorityTypes.Schedule, 10 },
                { PriorityTypes.ContactInfo, 10 },
                { PriorityTypes.LocationInfo, 10 },
                { PriorityTypes.PropertyType, 10 },
                { PriorityTypes.RoomAmenities, 10 },
                { PriorityTypes.AdditionalInfo, 10 },
                { PriorityTypes.TypeDescription, 10 },
                { PriorityTypes.TextualDescriptions, 10 },
                { PriorityTypes.AccommodationAmenities, 10 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "paximum", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 11 },
                { PriorityTypes.Photos, 12 },
                { PriorityTypes.Rating, 11 },
                { PriorityTypes.Category, 11 },
                { PriorityTypes.Schedule, 11 },
                { PriorityTypes.ContactInfo, 11 },
                { PriorityTypes.LocationInfo, 11 },
                { PriorityTypes.PropertyType, 11 },
                { PriorityTypes.RoomAmenities, 11 },
                { PriorityTypes.AdditionalInfo, 11 },
                { PriorityTypes.TypeDescription, 11 },
                { PriorityTypes.TextualDescriptions, 11 },
                { PriorityTypes.AccommodationAmenities, 11 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bronevik", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 14 },
                { PriorityTypes.Photos, 14 },
                { PriorityTypes.Rating, 14 },
                { PriorityTypes.Category, 14 },
                { PriorityTypes.Schedule, 14 },
                { PriorityTypes.ContactInfo, 14 },
                { PriorityTypes.LocationInfo, 14 },
                { PriorityTypes.PropertyType, 14 },
                { PriorityTypes.RoomAmenities, 14 },
                { PriorityTypes.AdditionalInfo, 14 },
                { PriorityTypes.TypeDescription, 14 },
                { PriorityTypes.TextualDescriptions, 14 },
                { PriorityTypes.AccommodationAmenities, 14 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hotelBeds", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 13 },
                { PriorityTypes.Photos, 1 },
                { PriorityTypes.Rating, 13 },
                { PriorityTypes.Category, 13 },
                { PriorityTypes.Schedule, 13 },
                { PriorityTypes.ContactInfo, 13 },
                { PriorityTypes.LocationInfo, 13 },
                { PriorityTypes.PropertyType, 13 },
                { PriorityTypes.RoomAmenities, 13 },
                { PriorityTypes.AdditionalInfo, 13 },
                { PriorityTypes.TypeDescription, 13 },
                { PriorityTypes.TextualDescriptions, 13 },
                { PriorityTypes.AccommodationAmenities, 13 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hotelbookPro", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 12 },
                { PriorityTypes.Photos, 13 },
                { PriorityTypes.Rating, 12 },
                { PriorityTypes.Category, 12 },
                { PriorityTypes.Schedule, 12 },
                { PriorityTypes.ContactInfo, 12 },
                { PriorityTypes.LocationInfo, 12 },
                { PriorityTypes.PropertyType, 12 },
                { PriorityTypes.RoomAmenities, 12 },
                { PriorityTypes.AdditionalInfo, 12 },
                { PriorityTypes.TypeDescription, 12 },
                { PriorityTypes.TextualDescriptions, 12 },
                { PriorityTypes.AccommodationAmenities, 12 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bookMe", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 15 },
                { PriorityTypes.Photos, 15 },
                { PriorityTypes.Rating, 15 },
                { PriorityTypes.Category, 15 },
                { PriorityTypes.Schedule, 15 },
                { PriorityTypes.ContactInfo, 15 },
                { PriorityTypes.LocationInfo, 15 },
                { PriorityTypes.PropertyType, 15 },
                { PriorityTypes.RoomAmenities, 15 },
                { PriorityTypes.AdditionalInfo, 15 },
                { PriorityTypes.TypeDescription, 15 },
                { PriorityTypes.TextualDescriptions, 15 },
                { PriorityTypes.AccommodationAmenities, 15 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "roibos", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 16 },
                { PriorityTypes.Photos, 16 },
                { PriorityTypes.Rating, 16 },
                { PriorityTypes.Category, 16 },
                { PriorityTypes.Schedule, 16 },
                { PriorityTypes.ContactInfo, 16 },
                { PriorityTypes.LocationInfo, 16 },
                { PriorityTypes.PropertyType, 16 },
                { PriorityTypes.RoomAmenities, 16 },
                { PriorityTypes.AdditionalInfo, 16 },
                { PriorityTypes.TypeDescription, 16 },
                { PriorityTypes.TextualDescriptions, 16 },
                { PriorityTypes.AccommodationAmenities, 16 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "avraTours", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 17 },
                { PriorityTypes.Photos, 17 },
                { PriorityTypes.Rating, 17 },
                { PriorityTypes.Category, 17 },
                { PriorityTypes.Schedule, 17 },
                { PriorityTypes.ContactInfo, 17 },
                { PriorityTypes.LocationInfo, 17 },
                { PriorityTypes.PropertyType, 17 },
                { PriorityTypes.RoomAmenities, 17 },
                { PriorityTypes.AdditionalInfo, 17 },
                { PriorityTypes.TypeDescription, 17 },
                { PriorityTypes.TextualDescriptions, 17 },
                { PriorityTypes.AccommodationAmenities, 17 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "accor", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 18 },
                { PriorityTypes.Photos, 18 },
                { PriorityTypes.Rating, 18 },
                { PriorityTypes.Category, 18 },
                { PriorityTypes.Schedule, 18 },
                { PriorityTypes.ContactInfo, 18 },
                { PriorityTypes.LocationInfo, 18 },
                { PriorityTypes.PropertyType, 18 },
                { PriorityTypes.RoomAmenities, 18 },
                { PriorityTypes.AdditionalInfo, 18 },
                { PriorityTypes.TypeDescription, 18 },
                { PriorityTypes.TextualDescriptions, 18 },
                { PriorityTypes.AccommodationAmenities, 18 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hyperGuest", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 19 },
                { PriorityTypes.Photos, 19 },
                { PriorityTypes.Rating, 19 },
                { PriorityTypes.Category, 19 },
                { PriorityTypes.Schedule, 19 },
                { PriorityTypes.ContactInfo, 19 },
                { PriorityTypes.LocationInfo, 19 },
                { PriorityTypes.PropertyType, 19 },
                { PriorityTypes.RoomAmenities, 19 },
                { PriorityTypes.AdditionalInfo, 19 },
                { PriorityTypes.TypeDescription, 19 },
                { PriorityTypes.TextualDescriptions, 19 },
                { PriorityTypes.AccommodationAmenities, 19 }
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
                migrationBuilder.UpdateData(table, keyColumn, supplier, column, new Dictionary<PriorityTypes, int>
                {
                    { PriorityTypes.Name, numberOfSuppliers },
                    { PriorityTypes.Photos, numberOfSuppliers },
                    { PriorityTypes.Rating, numberOfSuppliers },
                    { PriorityTypes.Category, numberOfSuppliers },
                    { PriorityTypes.Schedule, numberOfSuppliers },
                    { PriorityTypes.ContactInfo, numberOfSuppliers },
                    { PriorityTypes.LocationInfo, numberOfSuppliers },
                    { PriorityTypes.PropertyType, numberOfSuppliers },
                    { PriorityTypes.RoomAmenities, numberOfSuppliers },
                    { PriorityTypes.AdditionalInfo, numberOfSuppliers },
                    { PriorityTypes.TypeDescription, numberOfSuppliers },
                    { PriorityTypes.TextualDescriptions, numberOfSuppliers },
                    { PriorityTypes.AccommodationAmenities, numberOfSuppliers }
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
