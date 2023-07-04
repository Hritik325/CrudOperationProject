using MACHINEDOTNETTEST.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace MACHINEDOTNETTEST
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigurationServices(IServiceCollection services)
        {

            services.AddDbContext<MVCDemoDbContext>(options => options.UseSqlServer("MvcDemoConnectionStrinng"));
            services.AddMvc();

        }
    }
}
