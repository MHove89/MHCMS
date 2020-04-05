using MHCMS.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MHCMS.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            var provider =
                configuration.GetSection(InfrastructureConfigurationKeys.PersistenceSection)[
                    InfrastructureConfigurationKeys.DbProvider];

            if (provider == InfrastructureConfigurationKeys.Mssql)
            {
                ConfigureEntityFramework(services);
            }

            return services;
        }

        private static void ConfigureEntityFramework(IServiceCollection services)
        {
#if DEBUG
            services.AddDbContext<ApplicationDbContext>(o => o.UseInMemoryDatabase("MHCMS"));
#else
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString(InfrastructureConfigurationKeys.DatabaseName),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
#endif
        }
    }
}