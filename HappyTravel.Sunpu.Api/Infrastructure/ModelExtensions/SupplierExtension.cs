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
            Code = supplier.Code,
            Name = supplier.Name,
            EnableState = supplier.EnableState,
            ConnectorUrl = supplier.ConnectorUrl,
            ConnectorGrpcEndpoint = supplier.ConnectorGrpcEndpoint,
            IsMultiRoomFlowSupported = supplier.IsMultiRoomFlowSupported,
            CustomHeaders = supplier.CustomHeaders,
            CanUseGrpc = supplier.CanUseGrpc,
            GiataCode = supplier.GiataCode,
            IsDirectContract = supplier.IsDirectContract
        };
    }


    public static RichSupplier ToRichSupplier(this Supplier supplier)
    {
        return new RichSupplier
        {
            Code = supplier.Code,
            Name = supplier.Name,
            EnableState = supplier.EnableState,
            ConnectorUrl = supplier.ConnectorUrl,
            ConnectorGrpcEndpoint = supplier.ConnectorGrpcEndpoint,
            IsMultiRoomFlowSupported = supplier.IsMultiRoomFlowSupported,
            WebSite = supplier.WebSite,
            Description = supplier.Description,
            PrimaryContact = supplier.PrimaryContact,
            SupportContacts = supplier.SupportContacts,
            ReservationsContacts = supplier.ReservationsContacts,
            CustomHeaders = supplier.CustomHeaders,
            CanUseGrpc = supplier.CanUseGrpc,
            GiataCode = supplier.GiataCode,
            IsDirectContract = supplier.IsDirectContract
        };
    }
}
