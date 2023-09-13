using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.WebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
    }
}
