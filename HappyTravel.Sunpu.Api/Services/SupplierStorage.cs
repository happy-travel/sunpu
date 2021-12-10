using FloxDc.CacheFlow;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierStorage : ISupplierStorage
{
    public SupplierStorage(IMemoryFlow flow, SunpuContext sunpuContext)
    {
        _flow = flow;
        _sunpuContext = sunpuContext;
    }


    public async Task<List<Supplier>> Get(CancellationToken cancellationToken)
    {
        if (_flow.TryGetValue(SuppliersKey, out List<Supplier> suppliers))
            return suppliers;

        return await LoadFromDatabase(cancellationToken);
    }


    public async Task<Supplier?> Get(int supplierId, CancellationToken cancellationToken)
    {
        if (_flow.TryGetValue(SuppliersKey, out List<Supplier> suppliers))
            return suppliers.SingleOrDefault(s => s.Id == supplierId);

        suppliers = await LoadFromDatabase(cancellationToken);

        return suppliers.SingleOrDefault(s => s.Id == supplierId);
    }


    public async Task Refresh(CancellationToken cancellationToken)
    { 
        await LoadFromDatabase(cancellationToken);
    }


    private async Task<List<Supplier>> LoadFromDatabase(CancellationToken cancellationToken)
    {
        var suppliers = await _sunpuContext.Suppliers.ToListAsync(cancellationToken);
        _flow.Set(SuppliersKey, suppliers, s_supplierLifeTime);

        return suppliers;
    }
        

    private const string SuppliersKey = "Suppliers";

    private static readonly TimeSpan s_supplierLifeTime = TimeSpan.FromHours(24);

    private readonly IMemoryFlow _flow;
    private readonly SunpuContext _sunpuContext;
}
