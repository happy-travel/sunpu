using HappyTravel.Sunpu.Api.Models;

namespace HappyTravel.Sunpu.Api.Infrastructure.ModelExtensions;

public static class RichSupplierExtensions
{
    public static SlimSupplier ToSlimSupplier(this RichSupplier richSupplier)
    {
        return new SlimSupplier
        {
            Id = default, // TODO: we really need this field in slim model?
            Code = richSupplier.Code,
            Name = richSupplier.Name,
            EnablementState = richSupplier.EnablementState,
            ConnectorUrl = richSupplier.ConnectorUrl,
            ConnectorGrpcEndpoint = richSupplier.ConnectorGrpcEndpoint,
            IsMultiRoomFlowSupported = richSupplier.IsMultiRoomFlowSupported,
            CustomHeaders = richSupplier.CustomHeaders,
            CanUseGrpc = richSupplier.CanUseGrpc
        };
    }
}