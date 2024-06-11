using GoBee.Infrastructure;
using GoBee.UseCases.Usuarios.CriarUsuario;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoBee.UseCases;

public static class IoC
{
    public static IServiceCollection AddGoBeeUseCases(this IServiceCollection services)
    {
        services.AddScoped<ICriarUsuario, CriarUsuario>();
        services.AddGoBeeInfrastructure();

        return services;
    }
}
