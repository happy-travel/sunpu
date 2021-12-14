using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Infrastructure.ModelExtensions;

public static class SupplierExtension
{
    public static SlimSupplier ToSlimSupplier(this Supplier supplier)
    {
        return new SlimSupplier
        {
            Id = supplier.Id,
            Name = supplier.Name,
            IsEnabled = supplier.IsEnabled,
            ConnectorUrl = supplier.ConnectorUrl
        };
    }


    public static RichSupplier ToRichSupplier(this Supplier supplier)
    {
        return new RichSupplier
        {
            Id = supplier.Id,
            Name = supplier.Name,
            IsEnabled = supplier.IsEnabled,
            ConnectorUrl = supplier.ConnectorUrl,
            WebSite = supplier.WebSite,
            Description = supplier.Description,
            PrimaryContact = supplier.PrimaryContact,
            SupportContacts = supplier.SupportContacts,
            ReservationsContacts = supplier.ReservationsContacts
        };
    }
}
