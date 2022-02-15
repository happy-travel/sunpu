using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierStorage
{
    Task<List<Supplier>> Get(CancellationToken cancellationToken);
    Task<Supplier?> Get(string supplierCode, CancellationToken cancellationToken);
    Task Refresh(CancellationToken cancellationToken);
}
