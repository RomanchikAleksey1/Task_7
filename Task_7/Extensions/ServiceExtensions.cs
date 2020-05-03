using Microsoft.Extensions.DependencyInjection;
using Task_7.Interfaces;
using Task_7.Repository;

namespace Task_7.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
