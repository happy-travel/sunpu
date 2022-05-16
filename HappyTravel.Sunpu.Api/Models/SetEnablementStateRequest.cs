using HappyTravel.Sunpu.Data.Models;
using Newtonsoft.Json;

namespace HappyTravel.Sunpu.Api.Models;

public record SetEnablementStateRequest
{
    /// <summary>
    /// New enablement state of a supplier
    /// </summary>
    public EnablementState State { get; init; }
   
    /// <summary>
    /// Reason to change enablement state of supplier
    /// </summary>
    public string Reason { get; init; }
}