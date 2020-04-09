using Microsoft.Extensions.Configuration;
using MHCMS.Infrastructure.StartUp;

namespace MHCMS.Web
{
    public class Startup : CMSStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }
    }
}