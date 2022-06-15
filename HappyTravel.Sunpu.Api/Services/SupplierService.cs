using CSharpFunctionalExtensions;
using FluentValidation;
using HappyTravel.MapperContracts.Public.Accommodations.Enums;
using HappyTravel.Sunpu.Api.Infrastructure;
using HappyTravel.Sunpu.Api.Infrastructure.Constants;
using HappyTravel.Sunpu.Api.Infrastructure.FunctionalExtensions;
using HappyTravel.Sunpu.Api.Infrastructure.ModelExtensions;
using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierService : ISupplierService
{
    public SupplierService(SunpuContext sunpuContext, ISupplierStorage supplierStorage, IMessageBus messageBus)
    {
        _sunpuContext = sunpuContext;
        _supplierStorage = supplierStorage;
        _messageBus = messageBus;
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
            .Ensure(IsUnique, "A supplier with the same code or name already exists")
            .Tap(Add)
            .Tap(RefreshStorage)
            .Tap(() => SendMessage(MessageBusTopics.SupplierAdded, richSupplier.ToSlimSupplier()));


        async Task<bool> IsUnique()
            => !await _sunpuContext.Suppliers.AnyAsync(s => s.Name.ToLower() == richSupplier.Name.ToLower(), cancellationToken) &&
               !await _sunpuContext.Suppliers.AnyAsync(s => s.Code.ToLower() == richSupplier.Code.ToLower(), cancellationToken);


        async Task Add()
        {
            var countSuppliers = await _sunpuContext.Suppliers.CountAsync(cancellationToken);

            _sunpuContext.Suppliers.Add(new Supplier
            {
                Name = richSupplier.Name,
                Code = richSupplier.Code,
                EnablementState = richSupplier.EnablementState,
                ConnectorUrl = richSupplier.ConnectorUrl,
                ConnectorGrpcEndpoint = richSupplier.ConnectorGrpcEndpoint,
                IsMultiRoomFlowSupported = richSupplier.IsMultiRoomFlowSupported,
                WebSite = richSupplier.WebSite,
                Description = richSupplier.Description,
                PrimaryContact = richSupplier.PrimaryContact,
                SupportContacts = richSupplier.SupportContacts,
                ReservationsContacts = richSupplier.ReservationsContacts,
                Created = DateTimeOffset.UtcNow,
                CustomHeaders = richSupplier.CustomHeaders,
                Priority = GetDefaultPriority(countSuppliers + 1),
                CanUseGrpc = richSupplier.CanUseGrpc
            });

            await _sunpuContext.SaveChangesAsync(cancellationToken);
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);

        static Result Validate(RichSupplier richSupplier)
            => GenericValidator<RichSupplier>.Validate(v =>
                {
                    v.RuleFor(rs => rs.Name).NotEmpty();
                    v.RuleFor(rs => rs.Code).NotEmpty();
                    v.When(rs => !string.IsNullOrEmpty(rs.Code), () => {
                        v.RuleFor(rs => rs.Code).Must(r => Char.IsLower(r.First()))
                            .WithMessage("Supplier code must be in camel case");
                        v.RuleFor(rs => rs.Code).Matches("^[a-zA-Z0-9]+$")
                            .WithMessage("The supplier code can only contain upper and lower case letters and numbers");
                    });
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
            .Tap(RefreshStorage)
            .Tap(() => SendMessage(MessageBusTopics.SupplierUpdated,richSupplier.ToSlimSupplier()));
        
        
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
            supplier.CanUseGrpc = richSupplier.CanUseGrpc;

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


    public async Task<Result> Delete(string supplierCode, CancellationToken cancellationToken)
    {
        var supplier = await GetSupplier(supplierCode, cancellationToken);
        
        return await supplier
            .Bind(Delete)
            .Tap(RefreshStorage)
            .Tap(() => SendMessage(MessageBusTopics.SupplierRemoved, supplier.Value.ToSlimSupplier()));


        async Task<Result> Delete(Supplier supplier)
        {
            _sunpuContext.Suppliers.Remove(supplier);
            await _sunpuContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }


        Task RefreshStorage()
            => _supplierStorage.Refresh(cancellationToken);
    }


    public async Task<Result> SetEnablementState(string supplierCode, EnablementState enablementState, string reason, CancellationToken cancellationToken)
    {
        var supplier = await GetSupplier(supplierCode, cancellationToken);
        
        return await GetSupplier(supplierCode, cancellationToken)
            .Ensure(IsEnablementStateValid, "Enablement state is not valid")
            .BindWithTransaction(_sunpuContext, supplier => Result.Success(supplier)
                .Tap(SetState)
                .Bind(SaveToHistory))
            .Tap(RefreshStorage)
            .Tap(() => SendMessage(MessageBusTopics.SupplierUpdated, supplier.Value.ToSlimSupplier()));


        bool IsEnablementStateValid(Supplier _)
            => Enum.IsDefined(typeof(EnablementState), enablementState);


        Task SetState(Supplier supplier)
        {
            supplier.EnablementState = enablementState;
            _sunpuContext.Suppliers.Update(supplier);

            return _sunpuContext.SaveChangesAsync(cancellationToken);
        }


        async Task<Result> SaveToHistory(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(reason))
                return Result.Failure("The reason for changing the enablement state is not specified");

            _sunpuContext.SupplierActivationHistory.Add(new SupplierActivationHistoryEntry
            {
                SupplierId = supplier.Id,
                EnablementState = enablementState,
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


    private static Dictionary<AccommodationDataTypes, int> GetDefaultPriority(int supplierCount)
    {
        var priorities = new Dictionary<AccommodationDataTypes, int>();
        foreach (var priorityType in Enum.GetValues(typeof(AccommodationDataTypes)))
        {
            priorities.Add((AccommodationDataTypes)priorityType, supplierCount);
        }

        return priorities;
    }


    private void SendMessage(string topicName, SlimSupplier message) 
        => _messageBus.Publish(topicName, message);


    private readonly SunpuContext _sunpuContext;
    private readonly ISupplierStorage _supplierStorage;
    private readonly IMessageBus _messageBus;
}
