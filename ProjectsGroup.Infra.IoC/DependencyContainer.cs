using Microsoft.Extensions.DependencyInjection;
using ProjectsGroup.Application.Interfaces;
using ProjectsGroup.Application.Services;
using ProjectsGroup.Domain.Interfaces;
using ProjectsGroup.Infra.Data.Repository;

namespace ProjectsGroup.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<IUserService, UserService>();
            
            // Infra.Data Layer
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}