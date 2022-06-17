using HappyTravel.Sunpu.Data.Models;
using Newtonsoft.Json;

namespace HappyTravel.Sunpu.Api.Models;

public record SetEnableStateRequest
{
    /// <summary>
    /// New enable state of a supplier
    /// </summary>
    public EnableState State { get; init; }
   
    /// <summary>
    /// Reason to change enable state of supplier
    /// </summary>
    public string Reason { get; init; }
}