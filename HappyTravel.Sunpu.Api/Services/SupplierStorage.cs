using FloxDc.CacheFlow;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierStorage : ISupplierStorage
{
    public SupplierStorage(IDistributedFlow flow, SunpuContext sunpuContext)
    {
        _flow = flow;
        _sunpuContext = sunpuContext;
    }


    public async Task<List<Supplier>> Get(CancellationToken cancellationToken)
    {
        return await _flow.GetOrSetAsync(key: SuppliersKey, 
            getValueFunction: async () => await LoadFromDatabase(cancellationToken),
            absoluteExpirationRelativeToNow: SupplierLifeTime, 
            cancellationToken: cancellationToken) ?? throw new NullReferenceException("Suppliers list cannot be null");
    }


    public async Task<Supplier?> Get(string supplierCode, CancellationToken cancellationToken)
    {
        var suppliers = await Get(cancellationToken);

        return suppliers.SingleOrDefault(s => s.Code == supplierCode);
    }


    public async Task Refresh(CancellationToken cancellationToken)
    { 
        var suppliers = await LoadFromDatabase(cancellationToken);
        await _flow.SetAsync(SuppliersKey, suppliers, SupplierLifeTime, cancellationToken);
    }


    private async Task<List<Supplier>> LoadFromDatabase(CancellationToken cancellationToken)
        => await _sunpuContext.Suppliers.ToListAsync(cancellationToken);
        

    private const string SuppliersKey = "Suppliers";

    private static readonly TimeSpan SupplierLifeTime = TimeSpan.FromMinutes(5);

    private readonly IDistributedFlow _flow;
    private readonly SunpuContext _sunpuContext;
}
