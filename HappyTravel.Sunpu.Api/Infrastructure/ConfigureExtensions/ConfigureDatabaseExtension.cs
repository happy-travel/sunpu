﻿using HappyTravel.Sunpu.Api.Infrastructure.Environment;
using HappyTravel.Sunpu.Data;
using HappyTravel.VaultClient;
using Microsoft.EntityFrameworkCore;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureDatabaseExtension
{
    public static IServiceCollection ConfigureDatabaseOptions(this WebApplicationBuilder builder)
    {
        var configuration = builder.Configuration;
        using var vaultClient = new VaultClient.VaultClient(new VaultOptions
        {
            BaseUrl = new Uri(EnvironmentVariableHelper.Get("Vault:Endpoint", configuration)),
            Engine = configuration["Vault:Engine"],
            Role = configuration["Vault:Role"]
        });

        vaultClient.Login(EnvironmentVariableHelper.Get("Vault:Token", configuration)).GetAwaiter().GetResult();
        var databaseOptions = vaultClient.Get(configuration["Database:Options"]).GetAwaiter().GetResult();

        return builder.Services.AddDbContextPool<SunpuContext>(options =>
        {
            var host = databaseOptions["host"];
            var port = databaseOptions["port"];
            var password = databaseOptions["password"];
            var userId = databaseOptions["userId"];

            var connectionString = configuration["Database:ConnectionString"];
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
