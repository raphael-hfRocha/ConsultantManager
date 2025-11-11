using Domain.Interface.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
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
            services.AddScoped<IConsultorRepository, ConsultorRepository>();

            return services;
        }
    }
}
