using FloxDc.CacheFlow;

namespace HappyTravel.Sunpu.Api.Services;

public class SupplierStorage : ISupplierStorage
{
    public SupplierStorage(IMemoryFlow flow)
    {
        _flow = flow;
    }


    public void Add(string token)
        => _flow.Set(TokenKey, token, s_tokenLifeTime);


    public string TryGet()
    {
        if (_flow.TryGetValue(TokenKey, out string token))
            return token;

        return string.Empty;
    }


    private const string TokenKey = "Token";
    private static readonly TimeSpan s_tokenLifeTime = TimeSpan.FromHours(24);

    private readonly IMemoryFlow _flow;
}
