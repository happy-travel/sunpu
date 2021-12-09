using CSharpFunctionalExtensions;
using HappyTravel.Sunpu.Api.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierService
{
    Task<List<SlimSupplier>> Get(CancellationToken cancellationToken);
    Task<Result<RichSupplier>> Get(int supplierId, CancellationToken cancellationToken);
    Task<Result> Add(RichSupplier richSupplier, CancellationToken cancellationToken);
    Task<Result> Modify(int supplierId, RichSupplier richSupplier, CancellationToken cancellationToken);
    Task<Result> Delete(int supplierId, CancellationToken cancellationToken);
    Task<Result> Activate(int supplierId, string reason, CancellationToken cancellationToken);
    Task<Result> Deactivate(int supplierId, string reason, CancellationToken cancellationToken);
}
