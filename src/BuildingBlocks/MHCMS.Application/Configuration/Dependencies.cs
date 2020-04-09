using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
namespace MHCMS.Application.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection ConfigureApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}