using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace MHCMS.Infrastructure.StartUp
{
    public abstract class BaseStartup
    {
        private readonly IConfiguration _configuration;
        
        protected BaseStartup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime)
        {
        }   
    }
}