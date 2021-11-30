namespace HappyTravel.Sunpu.Api.Models;

public record SlimSupplier
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public bool IsEnable { get; init; } = false;
    public string ConnectorUrl { get; init; } = string.Empty;
}
