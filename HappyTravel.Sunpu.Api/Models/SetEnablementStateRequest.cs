using HappyTravel.Sunpu.Data.Models;
using Newtonsoft.Json;

namespace HappyTravel.Sunpu.Api.Models;

public readonly struct SetEnablementStateRequest
{
    [JsonConstructor]
    public SetEnablementStateRequest(string reason, EnablementState state)
    {
        Reason = reason;
        State = state;
    }
        
    /// <summary>
    /// New enablement state of a supplier
    /// </summary>
    public EnablementState State { get; }
   
    /// <summary>
    /// Reason to change enablement state of supplier
    /// </summary>
    public string Reason { get; }
}