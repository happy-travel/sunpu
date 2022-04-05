using CSharpFunctionalExtensions;
using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HappyTravel.Sunpu.Api.Services
{
    public class SupplierPriorityService : ISupplierPriorityService
    {
        public SupplierPriorityService(SunpuContext sunpuContext)
        {
            _sunpuContext = sunpuContext;
        }


        public async Task<Result<SupplierPriorityByTypes>> GetPriority(CancellationToken cancellationToken)
        {
            var suppliers = await _sunpuContext.Suppliers.ToListAsync(cancellationToken);
            if (suppliers is null)
                return Result.Failure<SupplierPriorityByTypes>("Suppliers not found");

            var supplierPriorities = await _sunpuContext.Suppliers.ToDictionaryAsync(s => s.Code, s => s.Priority, cancellationToken);

            var supplierPriorityByTypes = new SupplierPriorityByTypes();
            foreach (var priorityType in Enum.GetValues(typeof(PriorityTypes)))
            {
                /*
                foreach (var supplier in suppliers)
                {
                    var supplierPriority = supplierPriorities!
                        .DefaultIfEmpty(new KeyValuePair<string, Dictionary<PriorityTypes, int>>(supplier.Code, GetEmptyDictionary(suppliers.Count)))
                        .Single(s => s.Key == supplier.Code);
                }
                */

                var priorities = supplierPriorities!
                        .Select(sp => new { Supplier = sp.Key, Order = sp.Value!
                            .Single(pt => pt.Key == (PriorityTypes)priorityType).Value })
                        .OrderBy(a => a.Order)
                        .Select(a => a.Supplier)
                        .ToList();

                supplierPriorityByTypes.Add((PriorityTypes)priorityType, priorities);
            }

            return supplierPriorityByTypes;
        }


        public async Task<Result> ModifyPriority(SupplierPriorityByTypes supplierPriorityByTypes, CancellationToken cancellationToken)
        {
            var suppliers = await _sunpuContext.Suppliers.ToListAsync(cancellationToken);
            if (suppliers is null)
                return Result.Failure("Suppliers not found");

            var priorityList = new List<PriorityCombination>();
            foreach (var supplierPriorityByType in supplierPriorityByTypes)
            {
                var priorityListByType = supplierPriorityByType.Value
                    .Select((p, index) => new PriorityCombination { SupplierCode = p, Priority = supplierPriorityByType.Key, Order = index + 1 } )
                    .ToList();
                priorityList.AddRange(priorityListByType);
            }

            foreach (var supplier in suppliers)
            {
                var supplierPriority = priorityList.Where(pl => pl.SupplierCode == supplier.Code)
                    .OrderBy(pl => pl.Priority)
                    //.Select(pl => new KeyValuePair<PriorityTypes, int>(pl.Priority, pl.Order))
                    .ToDictionary(pl => pl.Priority, pl => pl.Order);

                supplier.Priority = supplierPriority;
                _sunpuContext.Suppliers.Update(supplier);
            }
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }


        private static Dictionary<PriorityTypes, int> GetDefaultPriority(int supplierCount)
        {
            var priorities = new Dictionary<PriorityTypes, int>();
            foreach (var priorityType in Enum.GetValues(typeof(PriorityTypes)))
            {
                priorities.Add((PriorityTypes)priorityType, supplierCount);
            }

            return priorities;
        }


        private readonly SunpuContext _sunpuContext;
    }
}
