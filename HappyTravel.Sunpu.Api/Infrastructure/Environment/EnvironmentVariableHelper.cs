namespace HappyTravel.Sunpu.Api.Infrastructure.Environment
{
    public static class EnvironmentVariableHelper
    {
        public static bool IsLocal(this IHostEnvironment hostingEnvironment)
            => hostingEnvironment.IsEnvironment(LocalEnvironment);


        private const string LocalEnvironment = "Local";
    }
}
