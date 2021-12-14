﻿using HappyTravel.StdOutLogger.Extensions;
using HappyTravel.StdOutLogger.Infrastructure;
using HappyTravel.Sunpu.Api.Infrastructure.Environment;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureLoggingExtension
{
    public static void ConfigureLogging(this WebApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();
        
        if (builder.Environment.IsLocal())
            builder.Logging.AddConsole();
        else
        {
            builder.Logging.AddStdOutLogger(setup =>
            {
                setup.IncludeScopes = true;
                setup.RequestIdHeader = Constants.DefaultRequestIdHeader;
                setup.UseUtcTimestamp = true;
            });
            builder.Logging.AddSentry();
        }
    }
}