using HappyTravel.MapperContracts.Public.Accommodations.Enums;

namespace HappyTravel.Sunpu.Api.Models;

public class PriorityCombination
{
    public string SupplierCode { get; set; } = string.Empty;
    public AccommodationDataTypes Priority { get; set; }
    public int Order { get; set; }
}
