using HappyTravel.Sunpu.Api.Infrastructure.Options;
using IdentityServer4.AccessTokenValidation;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureAuthenticationExtension
{
    public static void ConfigureAuthentication(this WebApplicationBuilder builder)
    {
        var authorityOptions = builder.Configuration.GetSection("Authority").Get<AuthorityOptions>();
        
        builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = authorityOptions.AuthorityUrl;
                options.Audience = authorityOptions.Audience;
                options.RequireHttpsMetadata = true;
                options.AutomaticRefreshInterval = authorityOptions.AutomaticRefreshInterval;
            });
    }
}