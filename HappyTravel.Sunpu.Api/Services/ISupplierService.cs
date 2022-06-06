using CSharpFunctionalExtensions;
using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierService
{
    Task<List<SlimSupplier>> Get(CancellationToken cancellationToken);
    Task<Result<RichSupplier>> Get(string supplierCode, CancellationToken cancellationToken);
    Task<Result> Add(RichSupplier richSupplier, CancellationToken cancellationToken);
    Task<Result> Modify(string supplierCode, RichSupplier richSupplier, CancellationToken cancellationToken);
    Task<Result> Delete(string supplierCode, CancellationToken cancellationToken);
    Task<Result> SetEnablementState(string supplierCode, EnablementState enablementState, string reason, CancellationToken cancellationToken);
}
