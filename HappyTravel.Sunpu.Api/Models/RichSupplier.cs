using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Models
{
    public class RichSupplier
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public bool IsEnabled { get; init; }
        public string ConnectorUrl { get; init; } = string.Empty;
        public string? WebSite { get; init; }
        public string? Description { get; init; }
        public Contact? PrimaryContact { get; init; }
        public List<Contact>? SupportContacts { get; init; }
        public List<Contact>? ReservationsContacts { get; init; }
    }
}
