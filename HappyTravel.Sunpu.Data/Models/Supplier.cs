namespace HappyTravel.Sunpu.Data.Models;

public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsEnabled { get; set; }
    public string ConnectorUrl { get; set; } = string.Empty;
    public bool IsMultiRoomFlowSupported { get; set; }
    public string? WebSite { get; set; }
    public string? Description { get; set; }
    public Contact? PrimaryContact { get; set; }
    public List<Contact>? SupportContacts { get; set; }
    public List<Contact>? ReservationsContacts { get; set; }
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? Modified { get; set; }
}
