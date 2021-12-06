namespace HappyTravel.Sunpu.Data.Models;

public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsEnable { get; set; } = false;
    public string ConnectorUrl { get; set; } = string.Empty;
    public string? WebSite { get; set; }
    public string? Description { get; set; }
    public Contact? PrimaryContact { get; set; }
    public List<Contact>? SupportContacts { get; set; }
    public List<Contact>? ReservationsContacts { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Modified { get; set; } = DateTime.Now;
}
