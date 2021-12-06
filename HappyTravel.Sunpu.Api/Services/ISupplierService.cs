using HappyTravel.Sunpu.Api.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierService
{
    Task<List<SlimSupplier>> Get(CancellationToken cancellationToken);
    Task<SupplierData> Get(int id, CancellationToken cancellationToken);
}
