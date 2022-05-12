using HappyTravel.MapperContracts.Public.Accommodations.Enums;

namespace HappyTravel.Sunpu.Data.Models;

public class Supplier
{
    // TODO: Remove the Id when migration to the code will be finished
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsEnabled { get; set; }
    public OperationMode OperationMode { get; set; } = OperationMode.Disabled;
    public string ConnectorUrl { get; set; } = string.Empty;
    public string? ConnectorGrpcEndpoint { get; set; }
    public bool IsMultiRoomFlowSupported { get; set; }
    public string? WebSite { get; set; }
    public string? Description { get; set; }
    public Contact? PrimaryContact { get; set; }
    public List<Contact>? SupportContacts { get; set; }
    public List<Contact>? ReservationsContacts { get; set; }
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? Modified { get; set; }
    public Dictionary<string, string>? CustomHeaders { get; set; }
    public Dictionary<AccommodationDataTypes, int>? Priority { get; set; }
}
