using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.ServiceLayer.CustomerService;

namespace OnionArchitecture.Api.Configurations
{
    public class ServicesConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}
