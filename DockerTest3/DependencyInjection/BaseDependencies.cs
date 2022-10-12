using MediatR;
using System.Reflection;

namespace DockerTest3.DependencyInjection
{
    public static class BaseDependencies
    {
        public static IServiceCollection AddBaseDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
