using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.RepositoryLayer.RepositoryPattern;

namespace OnionArchitecture.Api.Configurations
{
    public class RepositoryConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
