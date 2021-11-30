using HappyTravel.Sunpu.Api.Infrastructure.Extensions;
using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierService : ISupplierService
{
    public SupplierService(SunpuContext sunpuContext)
    {
        _sunpuContext = sunpuContext;
    }


    public async Task<List<SlimSupplier>> Get(CancellationToken cancellationToken)
    {
        var suppliers = await _sunpuContext.Suppliers.ToListAsync(cancellationToken: cancellationToken);

        return suppliers.Select(s => s.ToSlimSupplier()).ToList();
    }


    private readonly SunpuContext _sunpuContext;
}
