using CSharpFunctionalExtensions;
using FluentValidation;
using HappyTravel.Sunpu.Api.Infrastructure;
using HappyTravel.Sunpu.Api.Infrastructure.Extensions;
using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
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

        return suppliers.Select(s => s.ToSlimSupplier())
            .ToList();
    }


    public async Task<Result<SupplierData>> Get(int supplierId, CancellationToken cancellationToken)
    {
        var supplier = await _sunpuContext.Suppliers.SingleOrDefaultAsync(s => s.Id == supplierId, cancellationToken);

        return supplier is null
            ? Result.Failure<SupplierData>($"The supplier with id {supplierId} is not found")
            : supplier.ToSupplierData();
    }


    public Task<Result> Add(SupplierData supplierData, CancellationToken cancellationToken)
    {
        return Validate(supplierData)
            .Ensure(IsUnique, "A supplier with the same name already exists")
            .Tap(Add);


        async Task<bool> IsUnique()
            => !await _sunpuContext.Suppliers.AnyAsync(r => r.Name.ToLower() == supplierData.Name.ToLower(), cancellationToken);


        Task Add()
        {
            _sunpuContext.Suppliers.Add(new Supplier
            {
                Name = supplierData.Name,
                IsEnable = supplierData.IsEnable,
                ConnectorUrl = supplierData.ConnectorUrl,
                WebSite = supplierData.WebSite,
                Description = supplierData.Description,
                PrimaryContact = supplierData.PrimaryContact,
                SupportContacts = supplierData.SupportContacts,
                ReservationsContacts = supplierData.ReservationsContacts,
                Created = DateTime.Now
            });

            return _sunpuContext.SaveChangesAsync(cancellationToken);
        }
    }


    public Task<Result> Modify(int supplierId, SupplierData supplierData, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierId, cancellationToken)
            .Check(supplier => Validate(supplierData))
            .Bind(Update);


        async Task<Result> Update(Supplier supplier)
        {
            supplier.Name = supplierData.Name;
            supplier.ConnectorUrl = supplierData.ConnectorUrl;
            supplier.WebSite = supplierData.WebSite;
            supplier.Description = supplierData.Description;
            supplier.PrimaryContact = supplierData.PrimaryContact;
            supplier.SupportContacts = supplierData.SupportContacts;
            supplier.ReservationsContacts = supplierData.ReservationsContacts;
            supplier.Modified = DateTime.Now;

            _sunpuContext.Suppliers.Update(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }


    public Task<Result> Delete(int supplierId, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierId, cancellationToken)
            .Bind(Delete);


        async Task<Result> Delete(Supplier supplier)
        {
            _sunpuContext.Suppliers.Remove(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }


    public Task<Result> Activate(int supplierId, string reason, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierId, cancellationToken)
            .Bind(Activate);


        async Task<Result> Activate(Supplier supplier)
        {
            supplier.IsEnable = true;

            _sunpuContext.Suppliers.Update(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }


    public Task<Result> Deactivate(int supplierId, string reason, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierId, cancellationToken)
            .Bind(Deactivate);


        async Task<Result> Deactivate(Supplier supplier)
        {
            supplier.IsEnable = false;

            _sunpuContext.Suppliers.Update(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }


    private static Result Validate(SupplierData supplierData)
        => GenericValidator<SupplierData>.Validate(v =>
            {
                v.RuleFor(r => r.Name).NotEmpty();
                v.RuleFor(r => r.ConnectorUrl).NotEmpty();
            },
            supplierData);


    private async Task<Result<Supplier>> GetSupplier(int supplierId, CancellationToken cancellationToken)
    {
        var supplier = await _sunpuContext.Suppliers.FirstOrDefaultAsync(s => s.Id == supplierId, cancellationToken);

        return supplier is null
            ? Result.Failure<Supplier>($"The supplier with id { supplierId} is not found")
            : supplier;
    }


    private readonly SunpuContext _sunpuContext;
}
