using IdentityServer4.AccessTokenValidation;

namespace HappyTravel.Sunpu.Api.Infrastructure.ConfigureExtensions;

public static class ConfigureAuthenticationExtension
{
    public static void ConfigureAuthentication(this WebApplicationBuilder builder, string apiName, string authorityUrl)
    {
        builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            .AddIdentityServerAuthentication(options =>
            {
                options.Authority = authorityUrl;
                options.ApiName = apiName;
                options.RequireHttpsMetadata = true;
                options.SupportedTokens = SupportedTokens.Jwt;
            });
    }
}