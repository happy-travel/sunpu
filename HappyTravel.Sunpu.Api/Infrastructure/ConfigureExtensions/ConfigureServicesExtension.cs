using System.Text.Json.Serialization;
using FloxDc.CacheFlow.Extensions;
using HappyTravel.ErrorHandling.Extensions;
using HappyTravel.Sunpu.Api.Infrastructure.Environment;
using HappyTravel.Sunpu.Api.Services;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureServicesExtension
{
    public static void ConfigureServices(this WebApplicationBuilder builder, IConfiguration configuration)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHealthChecks().AddRedis(EnvironmentVariableHelper.Get("Redis:Endpoint", configuration));
        builder.Services.AddProblemDetailsErrorHandling();
        builder.Services.AddResponseCompression();
        builder.Services.AddMemoryCache();
        builder.Services.AddDistributedFlow().AddStackExchangeRedisCache(options =>
        {
            options.Configuration = EnvironmentVariableHelper.Get("Redis:Endpoint", configuration);
        });
        builder.Services.ConfigureApiVersioning();
        builder.Services.ConfigureTracing(builder.Environment, builder.Configuration);
        builder.Services.ConfigureFlowOptions();
        builder.Services.ConfigureSwagger();
        builder.Services.AddMvc()
            .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
        builder.Services.AddTransient<ISupplierService, SupplierService>();
        builder.Services.AddTransient<ISupplierPriorityService, SupplierPriorityService>();
        builder.Services.AddTransient<ISupplierStorage, SupplierStorage>();
        
    }
}