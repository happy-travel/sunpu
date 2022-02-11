﻿namespace HappyTravel.Sunpu.Api.Models;

public record SlimSupplier
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public bool IsEnabled { get; init; }
    public string ConnectorUrl { get; init; } = string.Empty;
    public string? ConnectorGrpcEndpoint { get; set; }
    public bool IsMultiRoomFlowSupported { get; init; }
}
