using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Configuração do Firebase
        services.Configure<FirebaseConfig>(configuration.GetSection("Firebase"));
        services.AddSingleton(configuration.GetSection("Firebase").Get<FirebaseConfig>());

        // Repositórios
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}