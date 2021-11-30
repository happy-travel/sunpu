using FloxDc.CacheFlow.Extensions;
using HappyTravel.ErrorHandling.Extensions;
using HappyTravel.Sunpu.Api.Services;

namespace HappyTravel.Sunpu.Api.Infrastructure.Extensions;

public static class ConfigureServicesExtension
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        //var redisEndpoint = EnvironmentVariableHelper.Get("Redis:Endpoint", builder.Configuration);
        
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHealthChecks();
        builder.Services.AddProblemDetailsErrorHandling();
        builder.Services.AddResponseCompression();
        builder.Services.AddMemoryCache();
        builder.Services.AddMemoryFlow();
        //builder.Services.ConfigureStackExchangeRedis(redisEndpoint);
        //builder.Services.AddDoubleFlow();
        builder.Services.ConfigureApiVersioning();
        builder.Services.ConfigureTracing(builder.Environment, builder.Configuration); //, redisEndpoint);
        builder.Services.ConfigureFlowOptions();
        builder.Services.ConfigureSwagger();
        builder.Services.AddTransient<ISupplierService, SupplierService>();
    }
}