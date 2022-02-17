﻿using CSharpFunctionalExtensions;
using FluentValidation;
using HappyTravel.Sunpu.Api.Infrastructure;
using HappyTravel.Sunpu.Api.Infrastructure.ModelExtensions;
using HappyTravel.Sunpu.Api.Infrastructure.FunctionalExtensions;
using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierService : ISupplierService
{
    public SupplierService(SunpuContext sunpuContext, ISupplierStorage supplierStorage)
    {
        _sunpuContext = sunpuContext;
        _supplierStorage = supplierStorage;
    }


    public async Task<List<SlimSupplier>> Get(CancellationToken cancellationToken)
    {
        var suppliers = await _supplierStorage.Get(cancellationToken);

        return suppliers.Select(s => s.ToSlimSupplier())
            .ToList();
    }


    public async Task<Result<RichSupplier>> Get(string supplierCode, CancellationToken cancellationToken)
    {
        var supplier = await _supplierStorage.Get(supplierCode, cancellationToken);

        return supplier?.ToRichSupplier() ?? Result.Failure<RichSupplier>($"The supplier with code {supplierCode} is not found");
    }


    public Task<Result> Add(RichSupplier richSupplier, CancellationToken cancellationToken)
    {
        return Validate(richSupplier)
            .Ensure(IsUnique, "A supplier with the same name already exists")
            .Tap(Add)
            .Tap(RefreshStorage);


        async Task<bool> IsUnique()
            => !await _sunpuContext.Suppliers.AnyAsync(s => s.Name.ToLower() == richSupplier.Name.ToLower(), cancellationToken) &&
               !await _sunpuContext.Suppliers.AnyAsync(s => s.Code.ToLower() == richSupplier.Code.ToLower(), cancellationToken);


        Task Add()
        {
            _sunpuContext.Suppliers.Add(new Supplier
            {
                Name = richSupplier.Name,
                Code = richSupplier.Code,
                IsEnabled = richSupplier.IsEnabled,
                ConnectorUrl = richSupplier.ConnectorUrl,
                ConnectorGrpcEndpoint = richSupplier.ConnectorGrpcEndpoint,
                IsMultiRoomFlowSupported = richSupplier.IsMultiRoomFlowSupported,
                WebSite = richSupplier.WebSite,
                Description = richSupplier.Description,
                PrimaryContact = richSupplier.PrimaryContact,
                SupportContacts = richSupplier.SupportContacts,
                ReservationsContacts = richSupplier.ReservationsContacts,
                Created = DateTimeOffset.UtcNow,
                CustomHeaders = richSupplier.CustomHeaders
            });

            return _sunpuContext.SaveChangesAsync(cancellationToken);
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);

        static Result Validate(RichSupplier richSupplier)
            => GenericValidator<RichSupplier>.Validate(v =>
                {
                    v.RuleFor(r => r.Name).NotEmpty();
                    v.RuleFor(r => r.Code).NotEmpty();
                    v.RuleFor(r => r.Code).Must(c => Char.IsLower(c.First()))
                        .WithMessage("Supplier code must be in camel case");
                    v.RuleFor(r => r.ConnectorUrl).NotEmpty();
                },
                richSupplier);
    }


    public Task<Result> Modify(string supplierCode, RichSupplier richSupplier, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierCode, cancellationToken)
            .Check(_ => Validate(richSupplier))
            .Ensure(IsUnique, "A supplier with the same name already exists")
            .Bind(Update)
            .Tap(RefreshStorage);
        
        
        async Task<bool> IsUnique(Supplier supplier)
            => !await _sunpuContext.Suppliers.AnyAsync(s => s.Name.ToLower() == richSupplier.Name.ToLower() && s.Code != supplierCode, cancellationToken);


        async Task<Result> Update(Supplier supplier)
        {
            // Supplier code cannot be updated, so not getting the code from here is by design
            supplier.Name = richSupplier.Name;
            supplier.ConnectorUrl = richSupplier.ConnectorUrl;
            supplier.ConnectorGrpcEndpoint = richSupplier.ConnectorGrpcEndpoint;
            supplier.IsMultiRoomFlowSupported = richSupplier.IsMultiRoomFlowSupported;
            supplier.WebSite = richSupplier.WebSite;
            supplier.Description = richSupplier.Description;
            supplier.PrimaryContact = richSupplier.PrimaryContact;
            supplier.SupportContacts = richSupplier.SupportContacts;
            supplier.ReservationsContacts = richSupplier.ReservationsContacts;
            supplier.Modified = DateTimeOffset.UtcNow;
            supplier.CustomHeaders = richSupplier.CustomHeaders;

            _sunpuContext.Suppliers.Update(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);
        
        
        static Result Validate(RichSupplier richSupplier)
            => GenericValidator<RichSupplier>.Validate(v =>
                {
                    v.RuleFor(r => r.Name).NotEmpty();
                    v.RuleFor(r => r.ConnectorUrl).NotEmpty();
                },
                richSupplier);
    }


    public Task<Result> Delete(string supplierCode, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierCode, cancellationToken)
            .Bind(Delete)
            .Tap(RefreshStorage);


        async Task<Result> Delete(Supplier supplier)
        {
            _sunpuContext.Suppliers.Remove(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);
    }


    public Task<Result> Activate(string supplierCode, string reason, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierCode, cancellationToken)
            .BindWithTransaction(_sunpuContext, supplier => Result.Success(supplier)
                .Tap(Activate)
                .Bind(SaveToHistory))
            .Tap(RefreshStorage);


        Task Activate(Supplier supplier)
        {
            supplier.IsEnabled = true;
            _sunpuContext.Suppliers.Update(supplier);

            return _sunpuContext.SaveChangesAsync(cancellationToken);
        }


        async Task<Result> SaveToHistory(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(reason))
                return Result.Failure("The reason for activation is not specified");

            _sunpuContext.SupplierActivationHistory.Add(new SupplierActivationHistoryEntry
            {
                SupplierId = supplier.Id,
                IsEnabled = true,
                Reason = reason,
                Created = DateTime.UtcNow
            });
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);
    }


    public Task<Result> Deactivate(string supplierCode, string reason, CancellationToken cancellationToken)
    {
        return GetSupplier(supplierCode, cancellationToken)
            .BindWithTransaction(_sunpuContext, supplier => Result.Success(supplier)
                .Tap(Deactivate)
                .Bind(SaveToHistory))
            .Tap(RefreshStorage);


        Task Deactivate(Supplier supplier)
        {
            supplier.IsEnabled = false;
            _sunpuContext.Suppliers.Update(supplier);

            return _sunpuContext.SaveChangesAsync(cancellationToken);
        }


        async Task<Result> SaveToHistory(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(reason))
                return Result.Failure("The reason for deactivation is not specified");

            _sunpuContext.SupplierActivationHistory.Add(new SupplierActivationHistoryEntry
            {
                SupplierId = supplier.Id,
                IsEnabled = false,
                Reason = reason,
                Created = DateTime.UtcNow
            });
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);
    }


    private async Task<Result<Supplier>> GetSupplier(string supplierCode, CancellationToken cancellationToken)
    {
        var supplier = await _sunpuContext.Suppliers.FirstOrDefaultAsync(s => s.Code == supplierCode, cancellationToken);

        return supplier ?? Result.Failure<Supplier>($"The supplier with code {supplierCode} is not found");
    }


    private readonly SunpuContext _sunpuContext;
    private readonly ISupplierStorage _supplierStorage;
}
