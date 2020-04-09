using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
namespace MHCMS.Application.Configuration
{
    public class ApplicationConfiguration
    {
        public static IServiceCollection Add()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
            return serviceCollection;
        }
    }
}