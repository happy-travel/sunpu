using HappyTravel.Sunpu.Api.Models;

namespace HappyTravel.Sunpu.Api.Infrastructure.ModelExtensions;

public static class RichSupplierExtensions
{
    /// <summary>
    /// Method maps RichSupplier to SlimSupplier type
    /// </summary>
    /// <param name="richSupplier"></param>
    /// <returns></returns>
    public static SlimSupplier ToSlimSupplier(this RichSupplier richSupplier)
    {
        return new SlimSupplier
        {
            Id = default, // TODO: we really need this field in slim model?
            Code = richSupplier.Code,
            Name = richSupplier.Name,
            EnableState = richSupplier.EnableState,
            ConnectorUrl = richSupplier.ConnectorUrl,
            ConnectorGrpcEndpoint = richSupplier.ConnectorGrpcEndpoint,
            IsMultiRoomFlowSupported = richSupplier.IsMultiRoomFlowSupported,
            CustomHeaders = richSupplier.CustomHeaders,
            CanUseGrpc = richSupplier.CanUseGrpc
        };
    }
}