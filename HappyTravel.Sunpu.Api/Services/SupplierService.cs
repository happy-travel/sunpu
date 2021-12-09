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


    public async Task<Result<RichSupplier>> Get(int supplierId, CancellationToken cancellationToken)
    {
        var supplier = await _sunpuContext.Suppliers.SingleOrDefaultAsync(s => s.Id == supplierId, cancellationToken);

        return supplier is null
            ? Result.Failure<RichSupplier>($"The supplier with id {supplierId} is not found")
            : supplier.ToRichSupplier();
    }


    public Task<Result> Add(RichSupplier richSupplier, CancellationToken cancellationToken)
    {
        return Validate(richSupplier)
            .Ensure(IsUnique, "A supplier with the same name already exists")
            .Tap(Add);


        async Task<bool> IsUnique()
            => !await _sunpuContext.Suppliers.AnyAsync(r => r.Name.ToLower() == richSupplier.Name.ToLower(), cancellationToken);


        Task Add()
        {
            _sunpuContext.Suppliers.Add(new Supplier
            {
                Name = richSupplier.Name,
                IsEnabled = richSupplier.IsEnabled,
                ConnectorUrl = richSupplier.ConnectorUrl,
                WebSite = richSupplier.WebSite,
                Description = richSupplier.Description,
                PrimaryContact = richSupplier.PrimaryContact,
                SupportContacts = richSupplier.SupportContacts,
                ReservationsContacts = richSupplier.ReservationsContacts,
                Created = DateTime.Now
            });

            return _sunpuContext.SaveChangesAsync(cancellationToken);
        }
    }


    public Task<Result> Modify(int supplierId, RichSupplier richSupplier, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierId, cancellationToken)
            .Check(supplier => Validate(richSupplier))
            .Bind(Update);


        async Task<Result> Update(Supplier supplier)
        {
            supplier.Name = richSupplier.Name;
            supplier.ConnectorUrl = richSupplier.ConnectorUrl;
            supplier.WebSite = richSupplier.WebSite;
            supplier.Description = richSupplier.Description;
            supplier.PrimaryContact = richSupplier.PrimaryContact;
            supplier.SupportContacts = richSupplier.SupportContacts;
            supplier.ReservationsContacts = richSupplier.ReservationsContacts;
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
            supplier.IsEnabled = true;
            // TODO: Saving the reason for activation in the history will be added in task AA-944

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
            supplier.IsEnabled = false;
            // TODO: Saving the reason for deactivation in the history will be added in task AA-944

            _sunpuContext.Suppliers.Update(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }


    private static Result Validate(RichSupplier richSupplier)
        => GenericValidator<RichSupplier>.Validate(v =>
            {
                v.RuleFor(r => r.Name).NotEmpty();
                v.RuleFor(r => r.ConnectorUrl).NotEmpty();
            },
            richSupplier);


    private async Task<Result<Supplier>> GetSupplier(int supplierId, CancellationToken cancellationToken)
    {
        var supplier = await _sunpuContext.Suppliers.FirstOrDefaultAsync(s => s.Id == supplierId, cancellationToken);

        return supplier is null
            ? Result.Failure<Supplier>($"The supplier with id { supplierId} is not found")
            : supplier;
    }


    private readonly SunpuContext _sunpuContext;
}
