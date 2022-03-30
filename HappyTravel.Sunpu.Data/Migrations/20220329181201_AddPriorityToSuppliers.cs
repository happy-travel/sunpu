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
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "illusions", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 7 },
                { PriorityTypes.Photos, 8 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "directContracts", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 5 },
                { PriorityTypes.Photos, 6 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "etg", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 4 },
                { PriorityTypes.Photos, 5 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "rakuten", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 8 },
                { PriorityTypes.Photos, 9 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "columbus", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 1 },
                { PriorityTypes.Photos, 2 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "travelgateXTest", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 9 },
                { PriorityTypes.Photos, 10 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "jumeirah", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 2 },
                { PriorityTypes.Photos, 3 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "darina", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 3 },
                { PriorityTypes.Photos, 4 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "yalago", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 10 },
                { PriorityTypes.Photos, 11 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "paximum", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 11 },
                { PriorityTypes.Photos, 12 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "travelLine", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bronevik", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 14 },
                { PriorityTypes.Photos, 14 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "travelClick", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "sodis", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hotelBeds", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 13 },
                { PriorityTypes.Photos, 1 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hotelbookPro", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 12 },
                { PriorityTypes.Photos, 13 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bookMe", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 15 },
                { PriorityTypes.Photos, 15 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "roibos", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 16 },
                { PriorityTypes.Photos, 16 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "sabre", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "bakuun", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "accor", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "nirvana", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "nuitee", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "hyperGuest", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "solole", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "grnConnect", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "methabook", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "withinearth", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "mtsCityBreaks", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "avraTours", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 17 },
                { PriorityTypes.Photos, 17 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "ddHolidays", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "htTest", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            migrationBuilder.UpdateData(table, keyColumn, "illusionsDirect", column, new Dictionary<PriorityTypes, int>
            {
                { PriorityTypes.Name, 0 },
                { PriorityTypes.Photos, 0 },
                { PriorityTypes.Rating, 0 },
                { PriorityTypes.Category, 0 },
                { PriorityTypes.Schedule, 0 },
                { PriorityTypes.ContactInfo, 0 },
                { PriorityTypes.LocationInfo, 0 },
                { PriorityTypes.PropertyType, 0 },
                { PriorityTypes.RoomAmenities, 0 },
                { PriorityTypes.AdditionalInfo, 0 },
                { PriorityTypes.TypeDescription, 0 },
                { PriorityTypes.TextualDescriptions, 0 },
                { PriorityTypes.AccommodationAmenities, 0 }
            });
            /*
            { "name": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "photos": [ "hotelBeds", "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "rating": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "category": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "schedule": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "contactInfo": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "locationInfo": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "propertyType": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "roomAmenities": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "additionalInfo": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "typeDescription": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "textualDescriptions": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ], 
            "accommodationAmenities": [ "columbus", "jumeirah", "darina", "etg", "directContracts", "netstorming", "illusions", "rakuten", "travelgateXTest", "yalago", "paximum", "hotelbookPro", "hotelBeds", "bronevik", "bookMe", "roibos", "avraTours" ] }
            */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Suppliers");
        }
    }
}
