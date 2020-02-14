using Microsoft.Extensions.DependencyInjection;

namespace Reacher.Utilities
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection ReacherLibrary(this IServiceCollection services)
        {
            services.AddHttpClient();
            return services;
        }
    }
}