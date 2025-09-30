using Invoicer.Front.App.Projects.Services;

namespace Invoicer.Front.App.Projects;

public class Configuration
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ProjectService>();
    }
}
