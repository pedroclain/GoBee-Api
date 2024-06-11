using GoBee.Infrastructure.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace GoBee.Infrastructure;

public static class IoC
{
    public static IServiceCollection AddGoBeeInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

        return services;
    }
}
