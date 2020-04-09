using MHCMS.Application.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MHCMS.Infrastructure.Configuration
{
    public static class CMSConfiguration
    {
        public static void AddMHCMS(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureInfrastructure(configuration);
            services.ConfigureApplication();
        }
    }
}
