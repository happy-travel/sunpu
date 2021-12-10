using FloxDc.CacheFlow;
using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierStorage : ISupplierStorage
{
    public SupplierStorage(IMemoryFlow flow)
    {
        _flow = flow;
    }


    public void Add(Supplier supplier)
        => _flow.Set(supplier.Id.ToString(), supplier, s_supplierLifeTime);


    public Supplier? TryGet(int supplierId)
    {
        if (_flow.TryGetValue(supplierId.ToString(), out Supplier supplier))
            return supplier;

        return null;
    }


    private static readonly TimeSpan s_supplierLifeTime = TimeSpan.FromHours(24);

    private readonly IMemoryFlow _flow;
}
