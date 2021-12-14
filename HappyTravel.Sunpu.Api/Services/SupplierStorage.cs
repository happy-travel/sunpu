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
        return await _flow.GetOrSetAsync(SuppliersKey, async () => await LoadFromDatabase(cancellationToken), supplierLifeTime, cancellationToken);
    }


    public async Task<Supplier?> Get(int supplierId, CancellationToken cancellationToken)
    {
        var suppliers = await Get(cancellationToken);

        return suppliers.SingleOrDefault(s => s.Id == supplierId);
    }


    public async Task Refresh(CancellationToken cancellationToken)
    { 
        var suppliers = await LoadFromDatabase(cancellationToken);
        _flow.Set(SuppliersKey, suppliers, supplierLifeTime);
    }


    private async Task<List<Supplier>> LoadFromDatabase(CancellationToken cancellationToken)
        => await _sunpuContext.Suppliers.ToListAsync(cancellationToken);
        

    private const string SuppliersKey = "Suppliers";

    private static readonly TimeSpan supplierLifeTime = TimeSpan.FromHours(24);

    private readonly IMemoryFlow _flow;
    private readonly SunpuContext _sunpuContext;
}
