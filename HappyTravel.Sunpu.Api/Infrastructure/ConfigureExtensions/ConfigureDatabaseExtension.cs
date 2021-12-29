using HappyTravel.Sunpu.Data;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureDatabaseExtension
{
    public static IServiceCollection ConfigureDatabaseOptions(this WebApplicationBuilder builder, Dictionary<string, string> databaseOptions)
    {
        return builder.Services.AddDbContextPool<SunpuContext>(options =>
        {
            var host = databaseOptions["host"];
            var port = databaseOptions["port"];
            var password = databaseOptions["password"];
            var userId = databaseOptions["userId"];

            var connectionString = builder.Configuration["Database:ConnectionString"];
            options.UseNpgsql(string.Format(connectionString, host, port, userId, password), builder =>
            {
                builder.EnableRetryOnFailure();
            });
            options.UseInternalServiceProvider(null);
            options.EnableSensitiveDataLogging(false);
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }, 16);
    }
}
