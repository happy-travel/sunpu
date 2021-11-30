using Microsoft.AspNetCore.Mvc;

namespace HappyTravel.Sunpu.Api.Infrastructure.Extensions;

public static class ConfigureApiVersioningExtension
{
    public static void ConfigureApiVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.AssumeDefaultVersionWhenUnspecified = false;
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.ReportApiVersions = true;
        });
    }
}