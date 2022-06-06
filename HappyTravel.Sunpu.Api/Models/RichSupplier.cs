﻿using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Models;

public class RichSupplier
{
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public EnablementState EnablementState { get; init; }
    public string ConnectorUrl { get; init; } = string.Empty;
    public string? ConnectorGrpcEndpoint { get; set; }
    public bool IsMultiRoomFlowSupported { get; init; }
    public string? WebSite { get; init; }
    public string? Description { get; init; }
    public Contact? PrimaryContact { get; init; }
    public List<Contact>? SupportContacts { get; init; }
    public List<Contact>? ReservationsContacts { get; init; }
    public Dictionary<string, string>? CustomHeaders { get; init; }
    public bool CanUseGrpc { get; set; }
}
