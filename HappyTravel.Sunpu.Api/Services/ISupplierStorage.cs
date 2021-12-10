using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierStorage
{
    Task<List<Supplier>> Get(CancellationToken cancellationToken);
    Task<Supplier?> Get(int supplierId, CancellationToken cancellationToken);
    Task Refresh(CancellationToken cancellationToken);
}
