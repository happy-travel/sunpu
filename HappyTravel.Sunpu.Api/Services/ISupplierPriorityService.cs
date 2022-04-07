using CSharpFunctionalExtensions;
using HappyTravel.Sunpu.Api.Models;

namespace HappyTravel.Sunpu.Api.Services
{
    public interface ISupplierPriorityService
    {
        Task<Result<SupplierPriorityByTypes>> GetPriority(CancellationToken cancellationToken);
        Task<Result> ModifyPriority(SupplierPriorityByTypes supplierPriorityByTypes, CancellationToken cancellationToken);
    }
}
