using CSharpFunctionalExtensions;
using HappyTravel.Sunpu.Api.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierService
{
    Task<List<SlimSupplier>> Get(CancellationToken cancellationToken);
    Task<Result<SupplierData>> Get(int supplierId, CancellationToken cancellationToken);
    Task<Result> Add(SupplierData supplierData, CancellationToken cancellationToken);
    Task<Result> Modify(int supplierId, SupplierData supplierData, CancellationToken cancellationToken);
    Task<Result> Delete(int supplierId, CancellationToken cancellationToken);
    Task<Result> Activate(int supplierId, string reason, CancellationToken cancellationToken);
    Task<Result> Deactivate(int supplierId, string reason, CancellationToken cancellationToken);
}
