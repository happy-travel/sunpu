using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Infrastructure.Extensions;

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


    public static SupplierData ToSupplierData(this Supplier supplier)
    {
        return new SupplierData
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
