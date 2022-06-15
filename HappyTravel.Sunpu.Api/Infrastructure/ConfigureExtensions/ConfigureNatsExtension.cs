using NATS.Client;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureNatsExtension
{
    public static void ConfigureNats(this WebApplicationBuilder builder)
    {
        var natsEndpoints = builder.Configuration.GetValue<string>("Nats:Endpoints").Split(";");
        builder.Services.AddNatsClient(options =>
        {
            options.Servers = natsEndpoints;
            options.MaxReconnect = NATS.Client.Options.ReconnectForever;
        }, ServiceLifetime.Singleton);
    }
}