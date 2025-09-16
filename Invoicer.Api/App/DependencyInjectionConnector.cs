using Invoicer.Api.App.Projects.Services;

namespace Invoicer.Api.App;

public static class DependencyInjectionConnector
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ProjectsService>();
    }
}
