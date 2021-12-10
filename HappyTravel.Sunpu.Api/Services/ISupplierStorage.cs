using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Services;

public interface ISupplierStorage
{
    void Add(Supplier supplier);
    Supplier TryGet();
}
