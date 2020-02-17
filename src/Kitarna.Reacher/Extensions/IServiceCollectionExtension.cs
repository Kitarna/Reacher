using Kitarna.Reacher.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kitarna.Reacher.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection ReacherServiceCollection(this IServiceCollection services)
        {
            services.AddHttpClient<Reacher>();
            return services;
        }
    }
}
